# Arquitetura da Solução

Nesta seção são apresentados os detalhes técnicos da solução criada pela equipe, tratando da Arquitetura da Solução, as estruturas de dados e as telas já implementadas.

## Diagrama de Componentes

Os componentes que fazem parte da solução são apresentados na Figura que se segue.

<img src="img/arqSolucao.jpg" width="500">

A solução implementada conta com os seguintes módulos:
* Tela inicial: Interface básica do sistema
* Páginas Web: Conjunto de arquivos HTML, CSS, JavaScript e imagens que implementam as funcionalidades do sistema.
* Local Storage: Armazenamento mantido no Navegador, onde são implementados bancos de dados baseados em JSON. São eles:
* Criar Lembrete: Seção para programar os horários de alimentação.
* Cadastro: Seção para cadastrar um ou mais cães.
* Histórico: Registro de alimentação.
* Conectar Dispositivos: Seção para compartilhar com outros usuários o status e a tarefa de alimentação.

## Diagrama de Classes

O diagrama de classes é um diagrama estrutural e define uma estrutura estática de relacionamento entre as classes. Seguem as principais classes desenvolvidas neste projeto.

<img src="img/diagramaClasses 001.jpg" width="500">

## Modelo ER

<img src="img/Esquema Relacional.jpg" width="500">

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.]

As referências abaixo irão auxiliá-lo na geração do artefato “Modelo ER”.

> - [Como fazer um diagrama entidade relacionamento | Lucidchart](https://www.lucidchart.com/pages/pt/como-fazer-um-diagrama-entidade-relacionamento)

## Esquema Relacional

O Esquema Relacional corresponde à representação dos dados em tabelas juntamente com as restrições de integridade e chave primária.
 
As referências abaixo irão auxiliá-lo na geração do artefato “Esquema Relacional”.

> - [Criando um modelo relacional - Documentação da IBM](https://www.ibm.com/docs/pt-br/cognos-analytics/10.2.2?topic=designer-creating-relational-model)

## Modelo Físico (DDL)

CREATE TABLE Usuario
{
  ID_Usuario  char(3) PRIMARY KEY,
  Nome        char(20),
  Telefone    char(12),
}

CREATE TABLE Cachorro
{
  ID_Cachorro  char(3) PRIMARY KEY,
  Nome         char(20),
  Raca         char(15),
  Idade        char(2),
  CONSTRAINT FK_Cachorro_Usuario  char(3) FOREIGN KEY (Usuario) REFERENCES (ID_Usuario)
}

CREATE TABLE Alimentacao
{
  ID_Alimentacao    char(3) PRIMARY KEY,
  Hora_Alimentacao  char(5),
  Tipo_Comida       char(10),
  Quantidade        numeric,
  CONSTRAINT FK_Alimentacao_Cachorro  char(3) FOREIGN KEY (Cachorro) REFERENCES (ID_Cachorro)
}

Entregar um arquivo banco.sql contendo os scripts de criação das tabelas do banco de dados. Este arquivo deverá ser incluído dentro da pasta src\bd.

## Instruções SQL de Manipulação do BD (DML)

Entregar um arquivo dml.sql contendo os scripts de manipulação de banco de dados. Este arquivo deverá ser incluído dentro da pasta src\bd.

## Tecnologias Utilizadas

O desenvolvimento do projeto será realizado no programa Visual Studio, da Microsoft, em linguagem C# utilizado o modelo ASP.NET Core Web App(Model-View-Controller) que gera a visualização do portal (front-end), através do framework Bootstrap. Serão usados também, os seguintes pacotes NuGet:

- BCrypt.Net-Next - versão 4.0.3
- Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation - versão 8.0.0
- Microsoft.EntityFrameworkCore.SqlServer - versão 9.0.0
- Microsoft.EntityFrameworkCore.Tools - versão 9.0.0
- Microsoft.VisualStudio.Web.CodeGeneration.Design - versão 8.0.7




Descreva aqui qual(is) tecnologias você vai usar para resolver o seu problema, ou seja, implementar a sua solução. Liste todas as tecnologias envolvidas, linguagens a serem utilizadas, serviços web, frameworks, bibliotecas, IDEs de desenvolvimento, e ferramentas.

Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.

## Hospedagem

O site utilizará a plataforma git pages como ambiente de hospedagem do site do projeto. O site é mantido no ambiente da URL:
https://glauberlanna.github.io/ProjetoEixoIII/index.html
A publicação do site no git pages é feita por meio de uma submissão do projeto (push) via git para o repositório remoto que se encontra no endereço:
https://github.com/glauberlanna/ProjetoEixoIII.git
