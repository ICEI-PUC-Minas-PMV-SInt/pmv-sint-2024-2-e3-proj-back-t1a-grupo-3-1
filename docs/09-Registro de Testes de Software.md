# Registro de Testes de Software

## Testes Funcionais

## RF-001 Controle de Acesso sem Autenticação


| Teste  |  Resultado  |  Conclusão |
|--------|-------------|------------|
|Acesso à seção Home|Acesso concedido|Sucesso|
|Acesso à seção de Login|Acesso concedido|Sucesso|
|Acesso à seção Cachorros|Redirecionado à seção de Login|Sucesso|
|Teste em seção Alimentações|Redirecionado à seção de Login|Sucesso|
|Teste em seção Usuários|Redirecionado à seção de Login|Sucesso|

## RF-002 Controle de Acesso com Autenticação

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

## RF-003 Criar Novo Usuário
| Teste  |  Resultado  |  Conclusão |
|--------|-------------|------------|
|Preenchimento de Formulário|Campos habilitados e funcionando|Sucesso ao receber dados de cadastro.|
|Mensagem de Erro|Exibição de mensagem quando houve campos não preenchidos|Sucesso|
|Novo Usuário|Usuário criado com os dados informados|Sucesso ao criar perfil de usuário e gravá-lo no banco de dados|

<br><br><br><br><br>

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Relatório com as evidências dos testes de software realizados no sistema pela equipe, baseado em um plano de testes pré-definido.

## Avaliação

Discorra sobre os resultados do teste. Ressaltando pontos fortes e fracos identificados na solução. Comente como o grupo pretende atacar esses pontos nas próximas iterações. Apresente as falhas detectadas e as melhorias geradas a partir dos resultados obtidos nos testes.

> **Links Úteis**:
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
