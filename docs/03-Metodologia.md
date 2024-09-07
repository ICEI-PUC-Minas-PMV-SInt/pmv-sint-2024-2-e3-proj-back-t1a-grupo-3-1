
# Metodologia

Avaliando a composição da equipe, esta que tem poucos integrantes, a experiência com desenvolvimento e o prazo para a entrega do projeto, elege-se a metodologia Ágil denominada Scrum, com o intuito de priorizar o desenvolvimento e a satisfação do cliente (Product Owner).
Dentre várias razões, os processos ágeis têm se tornado os mais optados pelas empresas de engenharia de software, a presteza resultante do ciclo de iterações de entregas junto à avaliação do cliente, evita esforços desnecessários ou resultados insatisfatórios.

## Relação de Ambientes de Trabalho

Os artefatos do projeto serão desenvolvidos remotamente, portanto, será necessário o uso de algumas plataformas as quais possibilitam a interação, organização e acesso ao código e seus resultados. A relação dos ambientes com seu respectivo propósito é apresentada a seguir.

|          Ambiente         |Plataforma|Link de Acesso                                                                           
                                                                         |
|---------------------------|----------|------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|Repositório de código fonte|  GitHub  |ICEI-PUC-Minas-PMV-SInt/pmv-sint-2024-2-e3-proj-back-t1-pmv-sint-2024-2-e3-proj-back-t1a-BackEnd-ApplicationProjectTemplate:main.docs/05-Arquitetura da Solução.md|

## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

O projeto segue a seguinte convenção para o nome de branches:

- `main`: versão estável já testada do software
- `unstable`: versão já testada do software, porém instável
- `testing`: versão em testes do software
- `dev`: versão de desenvolvimento do software

Quanto à gerência de issues, o projeto adota a seguinte convenção para
etiquetas:

- `documentation`: melhorias ou acréscimos à documentação
- `bug`: uma funcionalidade encontra-se com problemas
- `enhancement`: uma funcionalidade precisa ser melhorada
- `feature`: uma nova funcionalidade precisa ser introduzida

Discuta como a configuração do projeto foi feita na ferramenta de versionamento escolhida. Exponha como a gerência de tags, merges, commits e branchs é realizada. Discuta como a gerência de issues foi realizada.

> **Links Úteis**:
> - [Microfundamento: Gerência de Configuração](https://pucminas.instructure.com/courses/87878/)
> - [Tutorial GitHub](https://guides.github.com/activities/hello-world/)
> - [Git e Github](https://www.youtube.com/playlist?list=PLHz_AreHm4dm7ZULPAmadvNhH6vk9oNZA)
>  - [Comparando fluxos de trabalho](https://www.atlassian.com/br/git/tutorials/comparing-workflows)
> - [Understanding the GitHub flow](https://guides.github.com/introduction/flow/)
> - [The gitflow workflow - in less than 5 mins](https://www.youtube.com/watch?v=1SXpE08hvGs)

## Gerenciamento de Projeto

A equipe utiliza metodologias ágeis, tendo escolhido o Scrum como base para
definição do processo de desenvolvimento.

A equipe está organizada da seguinte maneira:
  * Scrum Master: Glauber Rodrigues Lanna e Silva.
  * Product Owner: nome do professor.
Equipe de Desenvolvimento:
  * Dhenis Cruz Madeira.
  * Glauber Rodrigues Lanna e Silva.

Para organização e distribuição das tarefas do projeto, a equipe utilizará a plataforma Trello, com estrutura descrita a seguir:
Recursos: esta lista mantém um template de tarefas recorrentes com as configurações padronizadas que todos devem seguir. O objetivo é permitir a cópia destes templates para agilizar a criação de novos cartões.
* Backlog: recebe as tarefas a serem trabalhadas e representa o Product Backlog. Todas as atividades identificadas no decorrer do projeto também devem ser incorporadas a esta lista.
* To Do: Esta lista representa o Sprint Backlog. Este é o Sprint atual que estamos trabalhando.
* Doing: Quando uma tarefa tiver sido iniciada, esta será é movida a esta aba.
* Test: Checagem de Qualidade. Quando as tarefas são concluídas, eles são movidas para o “CQ”. No final da semana, eu revejo essa lista para garantir que tudo saiu perfeito.
* Done: nesta lista são colocadas as tarefas que passaram pelos testes e controle de qualidade e estão prontos para ser entregues ao usuário. Não há mais edições ou revisões necessárias, ele está agendado e pronto para a ação.
* Locked: Quando alguma coisa impede a conclusão da tarefa, ela é movida para esta lista juntamente com um comentário sobre o que está travando a tarefa.

O quadro kanban do grupo no Trello está disponível através da URL https://trello.com/b/1jTLwxe6/projeto-eixo-iii.

Figura 2.2 - Tela do Trello utilizada pela equipe.

A tarefas são, ainda, etiquetadas em função da natureza da atividade e seguem o seguinte esquema de cores/categorias:
1. Documentação.
2. Desenvolvimento.
3. Infraestrutura.
4. Testes.
5. Gerência de Projetos.


### Divisão de Papéis

Apresente a divisão de papéis entre os membros do grupo.

Exemplificação: A equipe utiliza metodologias ágeis, tendo escolhido o Scrum como base para definição do processo de desenvolvimento. A equipe está organizada da seguinte maneira:
- Scrum Master: Felipe Domingos;
- Product Owner: Rommel Carneiro;
- Equipe de Desenvolvimento: Pedro Penna, Pedro Ivo, Rodrigo Richard;
- Equipe de Design: Simone Nogueira.

> **Links Úteis**:
> - [11 Passos Essenciais para Implantar Scrum no seu Projeto](https://mindmaster.com.br/scrum-11-passos/)
> - [Scrum em 9 minutos](https://www.youtube.com/watch?v=XfvQWnRgxG0)
> - [Os papéis do Scrum e a verdade sobre cargos nessa técnica](https://www.atlassian.com/br/agile/scrum/roles)

### Processo

Coloque  informações sobre detalhes da implementação do Scrum seguido pelo grupo. O grupo deverá fazer uso do recurso de gerenciamento de projeto oferecido pelo GitHub, que permite acompanhar o andamento do projeto, a execução das tarefas e o status de desenvolvimento da solução.
 
> **Links Úteis**:
> - [Planejamento e Gestáo Ágil de Projetos](https://pucminas.instructure.com/courses/87878/pages/unidade-2-tema-2-utilizacao-de-ferramentas-para-controle-de-versoes-de-software)
> - [Sobre quadros de projeto](https://docs.github.com/pt/issues/organizing-your-work-with-project-boards/managing-project-boards/about-project-boards)
> - [Project management, made simple](https://github.com/features/project-management/)
> - [Sobre quadros de projeto](https://docs.github.com/pt/github/managing-your-work-on-github/about-project-boards)
> - [Como criar Backlogs no Github](https://www.youtube.com/watch?v=RXEy6CFu9Hk)
> - [Tutorial Slack](https://slack.com/intl/en-br/)

### Ferramentas

As ferramentas empregadas no projeto são:

- Editor de código.
- Ferramentas de comunicação
- Ferramentas de desenho de tela (_wireframing_)

O editor de código foi escolhido porque ele possui uma integração com o sistema de versão. As ferramentas de comunicação utilizadas possuem integração semelhante e por isso foram selecionadas. Por fim, para criar diagramas utilizamos essa ferramenta por melhor captar as necessidades da nossa solução.

Liste quais ferramentas foram empregadas no desenvolvimento do projeto, justificando a escolha delas, sempre que possível.
 
> **Possíveis Ferramentas que auxiliarão no gerenciamento**: 
> - [Slack](https://slack.com/)
> - [Github](https://github.com/)
