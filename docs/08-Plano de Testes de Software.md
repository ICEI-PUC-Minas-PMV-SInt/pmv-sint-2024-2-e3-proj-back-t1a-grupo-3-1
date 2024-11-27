# Plano de Testes de Software

# Testes Funcionais
Serão realizados os testes funcionais como segue:

# Controle de Acesso Sem Autenticação

Nestes testes pretende-se evidenciar a restrição de acesso a usuários não logados, sendo as seção inicial (Home) e a área de Login, liberadas ao acesso público, as seções remanescentes deverão ter seu acesso negado, e por ora, redirecionado à seção de Login.


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


## Testes Funcionais

## Controle de Acesso sem Autenticação


| Teste  |  Resultado  |  Conclusão |
|--------|-------------|------------|
|Acesso à seção Home|Acesso concedido|Sucesso|
|Acesso à seção de Login|Acesso concedido|Sucesso|
|Acesso à seção Cachorros|Redirecionado à seção de Login|Sucesso|
|Teste em seção Alimentações|Redirecionado à seção de Login|Sucesso|
|Teste em seção Usuários|Redirecionado à seção de Login|Sucesso|

## Controle de Acesso com Autenticação

`Usuário "ADMIN" `

| Teste  |  Resultado  |  Conclusão |
|--------|-------------|------------|
|Acesso à seção Home|Acesso concedido|Sucesso|
|Acesso à seção de Login|Acesso concedido|Sucesso|
|Acesso à seção Cachorros|Acesso concedido|Sucesso|
|Teste em seção Alimentações|Acesso concedido|Sucesso|
|Teste em seção Usuários|Acesso concedido|Sucesso|

`Usuário "USER" `

| Teste  |  Resultado  |  Conclusão |
|--------|-------------|------------|
|Acesso à seção Home|Acesso concedido|Sucesso|
|Acesso à seção de Login|Acesso concedido|Sucesso|
|Acesso à seção Cachorros|Acesso concedido|Sucesso|
|Teste em seção Alimentações|Acesso concedido|Sucesso|
|Teste em seção Usuários|Acesso Negado|Sucesso|
