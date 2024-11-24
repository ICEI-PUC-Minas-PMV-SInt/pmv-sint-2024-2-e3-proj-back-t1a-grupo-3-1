using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto_1._0_eixo3_2024.Models;

namespace Projeto_1._0_eixo3_2024.Controllers
{
    [Authorize(Roles ="Admin")]
    public class UsuariosController : Controller
    {
        private readonly AppDbContext _context;

        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Usuarios.ToListAsync());
        }
        //---Rota para tela de "Acesso Negado"-------------------------------------------------------------

        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }

        //---Login por NomeUsuario e Anonimously-----------------------------------------------------------

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(Usuario usuario)
        {
            var dados = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.NomeUsuario == usuario.NomeUsuario );

            if (dados == null)
            {
                ViewBag.Message = "Usuário e/ou senha inválidos!";
                return View();
            }

            bool senhaOk = BCrypt.Net.BCrypt.Verify(usuario.Senha, dados.Senha);

            if (senhaOk)
            {
                var Claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, dados.NomeUsuario),
                    new Claim(ClaimTypes.NameIdentifier, dados.IdUsuario.ToString()),
                    new Claim(ClaimTypes.Role, dados.Perfil.ToString())
                };

                var usuarioIdentity = new ClaimsIdentity(Claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(usuarioIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                    IsPersistent = true,
                };

                await HttpContext.SignInAsync(principal, props);

                return Redirect("/");

            }
            else
            {
                ViewBag.Message = "Usuário e/ou senha inválidos!";
            }

            return View();
        }

        /*  LOGIN FEITO PELO IdUsuario     
                        [HttpPost]
                        public async Task<IActionResult> Login(Usuario usuario)
                        {
                            var dados = await _context.Usuarios
                                .FindAsync(usuario.IdUsuario);

                            if(dados == null)
                            {
                                ViewBag.Message = "Usuário e/ou senha inválidos!";
                                return View();
                            }

                            bool senhaOk = BCrypt.Net.BCrypt.Verify(usuario.Senha, dados.Senha);

                            if(senhaOk)
                            {
                                var Claims = new List<Claim>
                                {
                                    new Claim(ClaimTypes.Name, dados.NomeUsuario),
                                    new Claim(ClaimTypes.NameIdentifier, dados.IdUsuario.ToString()),
                                    new Claim(ClaimTypes.Role, dados.Perfil.ToString())
                                };

                                var usuarioIdentity = new ClaimsIdentity(Claims, "login");
                                ClaimsPrincipal principal = new ClaimsPrincipal(usuarioIdentity);

                                var props = new AuthenticationProperties
                                {
                                    AllowRefresh = true,
                                    ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                                    IsPersistent = true,
                                };

                                await HttpContext.SignInAsync(principal, props);

                                return Redirect("/");

                            }
                            else
                            {
                                ViewBag.Message = "Usuário e/ou senha inválidos!";
                            }

                            return View();
                        }
        */

        [AllowAnonymous]
        public async Task <IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Login", "Usuarios");

        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.IdUsuario == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        //--------------------------------------------------------------------------------------------------------------------------
        // GET: Usuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdUsuario,NomeUsuario,Senha,Perfil")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        //--------------------------------------------------------------------------------------------------------------------------
        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdUsuario,NomeUsuario,Senha,Perfil")] Usuario usuario)
        {
            if (id != usuario.IdUsuario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.IdUsuario))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        //--------------------------------------------------------------------------------------------------------------------------
        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.IdUsuario == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.IdUsuario == id);
        }
    }
}
