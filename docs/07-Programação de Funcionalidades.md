# Programação de Funcionalidades

Para o sistema foram propostas as seguintes funcionalidades:

## Usuário
- Criar conta
- Fazer login
- Sair do login
- Exibir dados do usuário
- Editar dados do usuário
- Apagar usuário

## Cachorro
- Adicionar cachorro
- Visualizar informações sobre o cachorro adicionado
- Editar informações sobre o cachorro
- Remover um cachorro da lista

## Lembrete
- Programar lembrete de alimentação
- Editar lembrete de alimentação
- Remover lembrete de alimentação

## Registro
- Registrar alimentação
- Visualizar alimentação
- Editar uma alimentação
- Remover uma alimentação

# Funcionalidades Criadas

Seguindo o modelo MVC, inicialmente, foram criadas as seguintes estruturas a serem ligadas ao banco de dados:

## Usuário

    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        [Display(Name = "ID do Usuário")]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome do usuário!")]
        [Display(Name = "Nome do Usuário")]
        public string NomeUsuario { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Perfil do usuário!")]
        public Perfil Perfil { get; set; }

    }

    public enum Perfil
    {
        Admin,
        User
    }

## Cachorro

 ```
 [Table("Cachorros")]
 public class Cachorro
 {
     [Key]
     public int IdCachorro { get; set; }

     [Required(ErrorMessage ="Obrigatório informar o nome do cachorro!")]
     [Display(Name = "Nome")]
     public string NomeCachorro { get; set; }

     [Required(ErrorMessage = "Obrigatório informar a data de nascimento do cachorro!")]
     [Display(Name = "Nascimento")]
     public string NascimentoCachorro { get; set; }

     [Display(Name = "Raça")]
     public string RacaCachorro { get; set; }

     public ICollection<Alimentacao> Alimentacoes { get; set; }

 }
```
## Alimentação
```
  public class Alimentacao
  {
      [Key]
      public int IdAlimentacao { get; set; }

      [Display(Name = "Hora")]
      public DateTime HoraAlimentacao { get; set; } = DateTime.Now;

      [Required(ErrorMessage = "Obrigatório Informar o Tipo de Alimentação!")]
      [Display(Name = "Tipo de Alimentação")]
      public TipoAlimentacao Tipo { get; set; }

      [Required(ErrorMessage = "Obrigatório Informar a Quantidade de Alimento administrada!")]
      [Display(Name = "Quantidade")]
      public int QuantidadeAlimentacao { get; set; }

      [Required(ErrorMessage = "Obrigatório Informar a Unidade de Medida!")]
      [Display(Name = "Unidade de Medida")]
      public UnidadeMedida UnidadeMedida { get; set; }

      [Required(ErrorMessage = "Obrigatório Informar o Cachorro!")]
      [Display(Name = "Cachorro")]
      public int IdCachorro { get; set; }

      [ForeignKey("IdCachorro")]
      public Cachorro Cachorro { get; set; }

  }

  public enum TipoAlimentacao
  {
      Ração_Seca,
      Ração_Úmida,
      Alimento_Caseiro,
      Petisco,
      Alimento_Cru
  }

  public enum UnidadeMedida
  {
      Copo,
      gramas,
      Scoop,
      Vasilhame
  }
```

# Controller da Seção USUÁRIOS
Dentro do contexto Controller, foram criadas as funcionalidades, ilustradas a seguir:

## Login
``` 
        public IActionResult Login()
        {
            return View();
        }
```

## Logout
```
        [AllowAnonymous]
        public async Task <IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Login", "Usuarios");

        }
```

## Criar Usuário
```
        public IActionResult Create()
        {
            return View();
        }
```

## Editar Usuário
```
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
```

## Remover Usuário
```
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
```

# Controller da Seção CACHORROS

## Listar Todos os Cachorros Cadastrados
```
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Cachorros.ToListAsync();

            return View(dados);
        }
```

## Criar/Adicionar Cachorro
```
        public IActionResult Create() //HttpGet
        {
            return View();
        }
```

## Editar Informações Sobre um Cachorro
```
        public async Task<IActionResult> Edit(int? id) //HttpGet
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Cachorros.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }
```
## Visualizar Informações Sobre um Cachorro
```
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Cachorros.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }
```

## Remover Cadastro de um Cachorro
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Cachorros.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

# Controller da Seção ALIMENTAÇÕES

## Listar Todos os Registros de Alimentação
```
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Alimentacoes.Include(a => a.Cachorro);
            return View(await appDbContext.ToListAsync());
        }
```

## Registrar uma Alimentação
```
        public IActionResult Create()
        {
            ViewData["IdCachorro"] = new SelectList(_context.Cachorros, "IdCachorro", "NomeCachorro");
            return View();
        }
```

## Editar um Registro de Alimentação
```
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alimentacao = await _context.Alimentacoes.FindAsync(id);
            if (alimentacao == null)
            {
                return NotFound();
            }
            ViewData["IdCachorro"] = new SelectList(_context.Cachorros, "IdCachorro", "NomeCachorro", alimentacao.IdCachorro);
            return View(alimentacao);
        }
```

## Remover um Registro de Alimentação
```
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alimentacao = await _context.Alimentacoes
                .Include(a => a.Cachorro)
                .FirstOrDefaultAsync(m => m.IdAlimentacao == id);
            if (alimentacao == null)
            {
                return NotFound();
            }

            return View(alimentacao);
        }
```
[^1]: Foram exemplificados apenas os blocos GET do código, para maiores detalhes, o código se encontra nesta documentação na pasta "src"

<!--
<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Implementação do sistema descritas por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos os artefatos criados (código fonte) além das estruturas de dados utilizadas e as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.

Para cada requisito funcional, pode ser entregue um artefato desse tipo

> **Links Úteis**:
>
> - [Trabalhando com HTML5 Local Storage e JSON](https://www.devmedia.com.br/trabalhando-com-html5-local-storage-e-json/29045)
> - [JSON Tutorial](https://www.w3resource.com/JSON)
> - [JSON Data Set Sample](https://opensource.adobe.com/Spry/samples/data_region/JSONDataSetSample.html)
> - [JSON - Introduction (W3Schools)](https://www.w3schools.com/js/js_json_intro.asp)
> - [JSON Tutorial (TutorialsPoint)](https://www.tutorialspoint.com/json/index.htm)

-->
