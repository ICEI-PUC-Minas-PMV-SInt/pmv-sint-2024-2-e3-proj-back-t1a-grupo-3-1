# Especificações do Projeto

Objetiva-se a criação de um aplicativo móvel que ajude os usuários a manterem a alimentação regular de cães, através de lembretes personalizados, notificação automática e histórico de alimentação. Serão apresentados os diagramas de personas e histórias de usuários relatados em pesquisa feita através de questionários aplicados a clientes de petshop e estabelecimentos voltados à criação de cães.

## Personas

As personas levantadas durante o processo de entendimento do problema são apresentadas nos relatos que se seguem.

**Persona 1:** Sandra tem 28 anos, é designer gráfica, solteira, trabalha homeoffice e tem uma rotina flexível.
  **Necessidades:**
  Preocupada com a saúde e bem-estar de sua cadelinha Mara, gostaria de organizar seus horários de alimentação através de 
  lembretes para diferentes horários.
  **Frustrações:**
  Aplicativos que não têm opções para personalizar suas tarefas.
  Notificações que falham ou não são enviadas no momento programado.

**Persona 2:** Gisele Medeiros tem 37 anos, é contadora, casada e tem dois filhos. Sua rotina de trabalho é muito ocupada e irregular. Depende de lembretes anotados em calendários expostos em vários ambientes de seu dia-a-dia como, a mesa do escritório onde trabalha e a geladeira de sua cozinha.
  **Necessidades:**
  Garantir que seus filhos também lembrem de alimentar o cachorro.
  Lembretes que possam ser compartilhados com outros membros da família.
  Interface simples e intuitiva.
  Notificações claras e visíveis.
  **Frustrações:**
  Aplicativos complexos e difíceis de usar.
  Falta de integração com outros dispositivos usados pela família.

## Histórias de Usuários

A partir da compreensão do dia a dia das personas identificadas para o projeto, foram registradas as seguintes histórias de usuários.

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE`   |PARA ... `MOTIVO/VALOR`                 |
|--------------------|--------------------------------------|----------------------------------------|
|                    | Organizar horários de alimentação.   |                                        |
|       Sandra       | Segurança do funcionamento das       |          Garantir o bem estar          |
|                    | notificações.                        |          e saúde de seu animal         |
|                    | Interface personalizável.            |                                        |
|                    |                                      |                                        |
|                    |Compartilhar lembretes com a família. | Garantir que o animal seja alimentado. |
|  Gisele Medeiros   |Lembrar os filhos de alimentarem      |           Educar seus filhos.          |
|                    |o cachorro.                           |                                        |
|                    |                                      |                                        |

## Requisitos

O escopo funcional do projeto é definido por meio dos requisitos funcionais que descrevem as possibilidades interação dos usuários, bem como os requisitos não funcionais que descrevem os aspectos que o sistema deverá apresentar de maneira geral. Estes requisitos são apresentados a seguir. 

### Requisitos Funcionais

A tabela a seguir apresenta os requisitos do projeto, identificando a prioridade em que os mesmos deverão ser entregues.

|  ID  |              Descrição do Requisito               | Prioridade |
|------|---------------------------------------------------|------------|
|RF-001|Configurar horários de alimentação do animal.      |    ALTA    |
|RF-002|Registrar que o animal foi alimentado. (dia e hora)|    ALTA    |
|RF-003|Lançar notificações ao(s) usuário(s).              |    ALTA    |
|RF-004|Compartilhamento de status de alimentação.         |    MÉDIA   |
|RF-005|Cadastramento do(s) animal(is).                    |    MÉDIA   |
|RF-006|Exibir histórico de alimentação.                   |    ALTA    |

### Requisitos não Funcionais

A tabela a seguir apresenta os requisitos não funcionais que o projeto deverá atender.

|**ID**|               **Descrição do Requisito**                |Prioridade |
|------|---------------------------------------------------------|-----------|
|RF-001|O sistema deve ter resistência a falhas nas notificações.|   ALTA    |
|RF-002|Interface simples (clean) e intuitiva.                   |   ALTA    |
|RF-003|Interface personalizável                                 |  BAIXA    |

## Restrições

As questões que limitam a execução desse projeto e que se configuram como obrigações claras para o desenvolvimento do projeto em questão são apresentadas na tabela a seguir.

|ID|                         Restrição                            |
|--|--------------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre        |
|02| O desenvolvimento deve se restringir à tecnologia do Backend.|

## Diagrama de Casos de Uso

O diagrama de caso de uso é um diagrama de alto nível de abstração, utilizado nas reuniões de levantamento com os usuários, pois possui notação fácil e que auxilia o diálogo com os clientes ou usuários. Este diagrama é usado para a modelagem de requisitos funcionais e pode também servir como um contrato entre as partes, pois delimita o escopo do sistema.
A seguir, serão apresentadas algumas das funcionalidades básicas do sistema, tais como registro e consulta da alimentação de cães e notificação do horário ou esquecimento.

<img src="img/Figura - 01.jpg" >
Figura 1. Usuário faz o check contendo dia, horário e o animal cadastrado.


<img src="img/Figura - 03.jpg" >
Figura 2. Usuário notificado conforme o programado.


<img src="img/Figura - 02.jpg" >
Figura 3. Alteração de status para possíveis outros usuários incluídos.
