# Registro de Testes de Software

# Testes de Requisitos Funcionais

#TESTES DE CONTROLE DE ACESSO

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

## RF-003 Login do Usuário
| Teste  |  Resultado  |  Conclusão |
|--------|-------------|------------|
|Preenchimento correto dos campos|Campos habilitados e login realizado|Sucesso ao receber e autenticar os dados para login|
|Preenchimento incorreto dos campos|Autenticação não realizada e exibição de mensagem de erro|Sucesso ao negar acesso e exibir mensagem|
|Não preenchimento dos campos|Exibição de mensagem em caso de campos não preenchidos|Sucesso ao exibir mensagem|

<!-- *********************************************************************************************************************************************** -->

# TESTES DA SEÇÃO USUÁRIOS

## RF-004 Criar Novo Usuário
| Teste  |  Resultado  |  Conclusão |
|--------|-------------|------------|
|Preenchimento de Formulário|Campos habilitados e funcionando|Sucesso ao receber dados de cadastro.|
|Mensagem de Erro|Exibição de mensagem quando houve campos não preenchidos|Sucesso|
|Novo Usuário|Usuário criado com os dados informados|Sucesso ao criar perfil de usuário e gravá-lo no banco de dados|

## RF-005 Exibição de Informações sobre o Usuário
| Teste  |  Resultado  |  Conclusão |
|--------|-------------|------------|
|Dados Cadastrados|Exibir todos os dados cadastrados|Sucesso ao exibir os dados do cão.|
|Redirecionamento|Usuário redirecionado à seção de edição ao clicar no botão|Sucesso ao redirecionar|

## RF-006 Edição de Informações do Usuário
| Teste  |  Resultado  |  Conclusão |
|--------|-------------|------------|
|Campos Habilitados|Exibição dos campos e recebimento os dados para a alteração|Sucesso ao inserir e enviar os dados para alteração|
|Mensagem de Campo Obrigatório|Exibição da mensagem de campo obrigatório|Sucesso ao exibir a mensagem e não continuação da alteração|
|Alterações Realizadas|Exibição dos dados alterados na lista de Usuários e na seção de Detalhamento|Sucesso ao evidenciar a alteração feita|

## RF-007 Exclusão de Dados e Perfil do Usuário
| Teste  |  Resultado  |  Conclusão |
|--------|-------------|------------|
|Solicitação de Remoção|Exibição da página de confirmação de exclusão|Sucesso ao redirecionar à página|
|Certificar que o Usuário foi Removido|Informações sobre o usuário não são mais exibidas na lista de Usuários|Sucesso ao remover informações do usuário|
|Tentativa de Autenticação de Usuário Removido|Acesso negado e exibição de mensagem "Usuário e/ou senha inválidos!"|Sucesso ao evidenciar que a remoção foi executada|

<!-- *********************************************************************************************************************************************** -->

# TESTES DA SEÇÃO CACHORROS

## RF-008 Adicionar Cachorro
| Teste  |  Resultado  |  Conclusão |
|--------|-------------|------------|
|Preenchimento de Formulário|Campos habilitados e funcionando|Sucesso ao receber dados do cão.|
|Mensagem de Erro|Exibição de mensagem quando houve campos não preenchidos|Sucesso|
|Cachorro adicionado|Cachorro adicionado com os dados informados|Sucesso ao adicionar e gravar as informações do cão no banco de dados|

## RF-009 Exibição de Informações sobre o Cachorro
| Teste  |  Resultado  |  Conclusão |
|--------|-------------|------------|
|Dados Cadastrados|Exibir todos os dados cadastrados|Sucesso ao exibir os dados do cão.|
|Redirecionamento|Usuário redirecionado à seção de edição ao clicar no botão|Sucesso ao redirecionar|

## RF-010 Edição de Informações do Cachorro
| Teste  |  Resultado  |  Conclusão |
|--------|-------------|------------|
|Campos Habilitados|Exibição dos campos e recebimento os dados para a alteração|Sucesso ao inserir e enviar os dados para alteração|
|Mensagem de Campo Obrigatório|Exibição da mensagem de campo obrigatório|Sucesso ao exibir a mensagem e não continuação da alteração|
|Alterações Realizadas|Exibição dos dados alterados na lista de Cachorro e na seção de Detalhamento|Sucesso ao evidenciar a alteração feita|

## RF-011 Remoção de Cachorro
| Teste  |  Resultado  |  Conclusão |
|--------|-------------|------------|
|Solicitação de Remoção|Exibição da página de confirmação de exclusão|Sucesso ao redirecionar à página|
|Certificar que o Cachorro foi Removido|Informações sobre o Cachorro não são mais exibidas na lista de Cachorros|Sucesso ao remover o Cachorro|
|Certificar a não exibição na seção Registrar Alimentação|O Cachorro não foi mais exibido na lista do campo Cachorro|Sucesso ao remover o Cachorro|

<!-- *********************************************************************************************************************************************** -->

# TESTES DA SEÇÃO ALIMENTAÇÕES

## RF-012 Registrar Alimentação
| Teste  |  Resultado  |  Conclusão |
|--------|-------------|------------|
|Preenchimento de Formulário|Campos habilitados e funcionando|Sucesso ao receber dados do registro.|
|Alimentação Registrada|Alimentação registrada com os dados informados|Sucesso ao adicionar e gravar o registro de alimentação no banco de dados|

## RF-013 Exibição do Registro de Alimentação Detalhado
| Teste  |  Resultado  |  Conclusão |
|--------|-------------|------------|
|Alimentação Registrada|Exibir informações contidas no registro.|Sucesso ao exibir as informações detalhadas|
|Redirecionamento|Usuário redirecionado à seção de edição|Sucesso ao redirecionar|

## RF-014 Edição de Registro de Alimentação
| Teste  |  Resultado  |  Conclusão |
|--------|-------------|------------|
|Campos Habilitados|Exibição dos campos e recebimento dos dados para a alteração|Sucesso ao inserir e enviar os dados para alteração|
|Mensagem de Campo Obrigatório|Exibição da mensagem de campo obrigatório|Sucesso ao exibir a mensagem e não continuação da alteração|
|Alterações Realizadas|Exibição dos dados alterados na lista de Alimentações|Sucesso ao evidenciar a alteração feita|

## RF-015 Exclusão de Registro de Alimentação
| Teste  |  Resultado  |  Conclusão |
|--------|-------------|------------|
|Solicitação de Remoção|Exibição da página de confirmação de exclusão|Sucesso ao redirecionar à página|
|Certificar que o registro foi Removido|Registro de Alimentação não foi mais exibido na lista de Alimentações|Sucesso ao remover o registro|

# Testes de Requisitos Não Funcionais

## RNF-001 Criptografia de senha
| Teste  |  Resultado  |  Conclusão |
|--------|-------------|------------|
|Criptografar Senhas|Senhas Criptografadas verificado diretamente no Banco de Dados|Sucesso ao criptografar as senhas|
|| <img src="img/Prova de Criptografia.jpg" width="400"> ||

<!--

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Relatório com as evidências dos testes de software realizados no sistema pela equipe, baseado em um plano de testes pré-definido.

## Avaliação

Discorra sobre os resultados do teste. Ressaltando pontos fortes e fracos identificados na solução. Comente como o grupo pretende atacar esses pontos nas próximas iterações. Apresente as falhas detectadas e as melhorias geradas a partir dos resultados obtidos nos testes.

> **Links Úteis**:
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)

-->
