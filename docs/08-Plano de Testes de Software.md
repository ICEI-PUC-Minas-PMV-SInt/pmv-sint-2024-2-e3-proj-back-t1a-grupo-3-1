# Plano de Testes de Software

# Testes de Requisitos Funcionais
Serão realizados os testes para requisitos funcionais como segue:

# TESTES DE CONTROLE DE ACESSO
Nestes testes pretende-se evidenciar a restrição e permissão de acesso das seções citadas a seguir.

- Verificar acesso à seção /Home
- Verificar acesso à seção /Usuarios/Login
- Verificar acesso à seção /Cachorros
- Verificar acesso à seção /Alimentacoes
- Verificar acesso à seção /Usuarios

## RF-001 Controle de Acesso Sem Autenticação

Requisito: Nestes testes pretende-se evidenciar a restrição de acesso a usuários não logados, sendo a seção inicial (<i>Home</i>) e a área de Login, liberadas ao acesso público, as seções remanescentes deverão ter seu acesso negado, e por ora, redirecionado à seção de Login.

## RF-002 Controle de Acesso Com Autenticação

Requisito: Nestes testes pretende-se evidenciar o êxito ao efetuar o Login de usuário, tal qual, suas atribuições particulares aos distintos grupos de usuários; Administrador, representado pelo termo "<i>Admin</i>"
e Usuário comum, representado pelo termo "<i>User</i>".

Usuários <i>Admin</i> e <i>User</i> possuem acesso às seções Cachorros e Alimentações, porém, apenas o tipo <i>Admin</i> poderá acessar à seção Usuários

## RF-003 Login do Usuário

Requisito: O usuário deve poder fazer login utilizando o nome de usuário e senha cadastrados.

- Verificar se o formulário de login aceita os dados corretos.

- Verificar se o usuário é redirecionado para a página inicial após login bem-sucedido.

- Verificar se mensagens de erro são exibidas para dados incorretos.

<!-- ........................................................................................................................... -->

# TESTES DA SEÇÃO USUÁRIOS

## RF-004 Cadastro de Usuário

Requisito: O usuário deve poder se cadastrar fornecendo nome de usuário, tipo de conta e senha.

- Verificar se o formulário de cadastro aceita todos os campos necessários.

- Verificar se mensagens de erro são exibidas para campos não preenchidos.

- Verificar se o cadastro do usuário teve sucesso realizando o login no perfil criado.

## RF-005 Exibição de Informações sobre o Usuário

Requisito: Visualização das informações sobre o Usuário e possível alteração quando solicitada.

- Verificar a exibição dos dados ID do Usuário, Nome de Usuário e Tipo de Perfil(Admin ou User).

- Verificar a exibição e função de redirecionamento do botão Editar, para esta seção da plataforma.

## RF-006 Edição de Informações do Usuário

Requisito: O usuário deve poder editar as informações sobre um Usuário cadastrado.

- Verificar se os dados do usuário: ID, Nome, Senha e Perfil são carregados corretamente no formulário de edição.

- Verificar se a mensagem de campo obrigatório é exibida em caso de não preenchimento.

- Verificar se as alterações são gravadas corretamente.

## RF-007 Exclusão de Dados e Perfil do Usuário

Requisito: O usuário deve poder excluir o Perfil de um usuário.

- Verificar se a solicitação redirecionará o usuário à página de confirmação para a exclusão.

- Verificar se o perfil de usuário foi removido da lista de Usuários.

- Verificar se não ocorre mais a autenticação do usuário excluído.

<!-- ........................................................................................................................... -->

# TESTES DA SEÇÃO CACHORROS

## RF-008 Adicionar Cachorro

Requisito: O usuário deve poder adicionar um ou mais cães fornecendo seu nome, nascimento e raça.

- Verificar se o formulário de cadastro aceita todos os campos necessários.

- Verificar se mensagens de erro são exibidas para campos obrigatórios não preenchidos.

- Verificar se o adicionar do cachorro teve sucesso indicado pela lista de cachorros e visualização de seus dados.

## RF-009 Exibição de Informações sobre o Cachorro

Requisito: O usuário deve poder visualizar as informações sobre o cachorro solicitado.

- Verificar a exibição dos dados Nome, Raça e Data de Nascimento.

- Verificar a exibição e função de redirecionamento do botão Editar, para esta seção da plataforma.

## RF-010 Edição de Informações do Cachorro

Requisito: O usuário deve poder editar as informações sobre um Cachorro cadastrado.

- Verificar se os dados do cachorro: Nome, Data de Nascimento e Raça são carregados corretamente no formulário de edição.

- Verificar se a mensagem de campo obrigatório é exibida em caso de não preenchimento.

- Verificar se as alterações são gravadas corretamente.

## RF-011 Remoção de Cachorro

Requisito: O usuário deve poder excluir um Cachorro.

- Verificar se a solicitação redirecionará o usuário à página de confirmação para a exclusão.

- Verificar se o Cachorro foi removido da lista de Cachorros.

- Verificar se não há mais a exibição do nome do cachorro no campo Cachorro da seção de Registrar Alimentação.

<!-- ........................................................................................................................... -->

# TESTES DA SEÇÃO ALIMENTAÇÕES

## RF-012 Registrar Alimentação

Requisito: O sistema deve permitir que o usuário registre a alimentação de um cachorro listado, especificando qual o tipo de
alimentação foi administrado, a quantidade e sua unidade de medida, data e horário.

- Verificar se o formulário de registro aceita todos os campos necessários.

- Verificar se a alimentação é gravada corretamente no sistema.

## RF-013 Exibição do Registro de Alimentação Detalhado

Requisito: Visualização das informações sobre a Alimentação registrada e possível alteração quando solicitada.

- Verificar a exibição do Nome do Cachorro, Tipo de Alimentação, Quantidade e unidade de medida utilizada, e o Dia e Horário do registro.

- Verificar a exibição e função de redirecionamento do botão Editar, para esta seção da plataforma.

## RF-014 Edição de Registro de Alimentação

Requisito: O usuário deve poder editar as informações sobre um Registro de Alimentação.

- Verificar se os dados do registro: Cachorro, Tipo de Alimentação, Quantidade, Unidade de Medida e Hora são carregados corretamente no formulário de edição.

- Verificar se a mensagem de campo obrigatório é exibida em caso de não preenchimento.

- Verificar se as alterações do registro são gravadas corretamente.

## RF-015 Exclusão de Registro de Alimentação

Requisito: O usuário deve poder excluir uma Alimentação registrada.

- Verificar se a solicitação redirecionará o usuário à página de confirmação para a exclusão.

- Verificar se a alimentação foi removida da lista de Alimentações.

# Testes de Requisitos Não Funcionais
Serão realizados os testes para requisitos não funcionais como segue:

## RNF-001 Criptografia de senha

Requisito: A plataforma deverá criptografar a senha no momento de criação da conta do usuário, sendo gravada no Banco de Dados já criptografada.

- Verificar se as senhas, no banco de dados do SQL Server, estão criptografadas.


<!--
<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Enumere quais cenários de testes foram selecionados para teste. Neste tópico o grupo deve detalhar quais funcionalidades avaliadas, o grupo de usuários que foi escolhido para participar do teste e as ferramentas utilizadas.
 
## Ferramentas de Testes (Opcional)

Comente sobre as ferramentas de testes utilizadas.
 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)

-->
