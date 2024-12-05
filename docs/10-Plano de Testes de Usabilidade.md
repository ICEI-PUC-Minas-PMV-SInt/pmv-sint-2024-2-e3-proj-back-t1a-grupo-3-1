# Plano de Testes de Usabilidade

Os testes de usabilidade serão realizados para garantir que a interface do usuário seja intuitiva e fácil de usar.

## Objetivo dos Testes de Usabilidade:
- Avaliar a qualidade e a eficiência da interação do usuário com o site.
- Identificar problemas de usabilidade e possíveis melhorias na interface.

## Público-Alvo
- Pessoas que tenham um ou mais cães sob sua tutela.
- Pet Shops
- Clínicas Veterinárias
- Hotéis Para Cães

## Cenários de Teste

### Sistema de login

<b>Caso de Teste - 001: Criar Conta</b>

Passo 1: Acessar a página de Usuários e clicar em "Criar Usuário".

Passo 2: Inserir Nome, Senha e selecionar Tipo de Perfil (User/Admin).

Passo 3: Clicar no botão "Criar".

Resultado Esperado: Mensagem "Inclusão do usuário na lista de usuários".

<br>

<b>Caso de Teste - 002: Acessar Conta</b>

Passo 1: Acessar a página de Login através do botão "Login", situado ao canto superior direito da página.

Passo 2: Inserir Nome e Senha de usuário.

Passo 3: Clicar no botão "Acessar".

Resultado Esperado: Redirecionamento para a página do usuário, com o texto "Olá, <Nome do Usuário>" na área do botão Login.

<br>

Caso de Teste - 003: Criptografia de senha

Passo 1: Acessar no aplicativo SQL Server, o banco de dados conectado ao presente projeto.

Passo 2: Executar o comando ```SELECT Senha FROM Usuarios```.

Passo 3: Verificar se as senhas foram criptografadas.

Resultado Esperado: O retorno da pesquisa exibirá a coluna de senhas da tabela de Usuários contendo as informações em formato ilegível.

<br>

<b>Caso de Teste - 002: Sair da Conta</b>

Passo 1: Fazer o Logout da conta através do botão "Sair", situado ao canto superior direito da página.

Resultado Esperado: Redirecionamento para a página inicial, sem a exibição das seções e o nome de usuário.

<!-- O teste de usabilidade permite avaliar a qualidade da interface com o usuário da aplicação interativa. O Plano de Testes de Software é gerado a partir da especificação do sistema e consiste em casos de testes que deverão ser executados quando a implementação estiver parcial ou totalmente pronta.

As referências abaixo irão auxiliá-lo na geração do artefato "Plano de Testes de Usabilidade".

> **Links Úteis**:
> - [Teste De Usabilidade: O Que É e Como Fazer Passo a Passo (neilpatel.com)](https://neilpatel.com/br/blog/teste-de-usabilidade/)
> - [Teste de usabilidade: tudo o que você precisa saber! | by Jon Vieira | Aela.io | Medium](https://medium.com/aela/teste-de-usabilidade-o-que-voc%C3%AA-precisa-saber-39a36343d9a6/)
> - [Planejando testes de usabilidade: o que (e o que não) fazer | iMasters](https://imasters.com.br/design-ux/planejando-testes-de-usabilidade-o-que-e-o-que-nao-fazer/)
> - [Ferramentas de Testes de Usabilidade](https://www.usability.gov/how-to-and-tools/resources/templates.html)
-->
