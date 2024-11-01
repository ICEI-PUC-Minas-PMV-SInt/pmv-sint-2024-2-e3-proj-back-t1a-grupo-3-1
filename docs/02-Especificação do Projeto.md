# Especificações do Projeto

Objetiva-se a criação de um aplicativo móvel que ajude os usuários a manterem a alimentação regular de cães, através de lembretes personalizados, notificação automática e histórico de alimentação. Serão apresentados os diagramas de personas e histórias de usuários relatados em pesquisa feita através de questionários aplicados a clientes de petshop e estabelecimentos voltados à criação de cães.

## Personas

As personas levantadas durante o processo de entendimento do problema são apresentadas nos relatos que se seguem.

**Persona 1:** Sandra tem 28 anos, é designer gráfica, solteira, trabalha homeoffice e tem uma rotina flexível. <br><br>
* **Necessidades:** Preocupada com a saúde e bem-estar de sua cadelinha Mara, gostaria de organizar seus horários de alimentação através de lembretes para diferentes horários. <br><br>
* **Frustrações:** Aplicativos que não têm opções para personalizar suas tarefas. Notificações que falham ou não são enviadas no momento programado. <br><br><br>

**Persona 2:** Gisele Medeiros tem 37 anos, é contadora, casada e tem dois filhos. Sua rotina de trabalho é muito ocupada e irregular. Depende de lembretes anotados em calendários expostos em vários ambientes de seu dia-a-dia como, a mesa do escritório onde trabalha e a geladeira de sua cozinha. <br><br>
* **Necessidades:** Garantir que seus filhos também lembrem de alimentar o cachorro. Lembretes que possam ser compartilhados com outros membros da família. Interface simples e intuitiva. Notificações claras e visíveis. <br><br>
* **Frustrações:** Aplicativos complexos e difíceis de usar. Falta de integração com outros dispositivos usados pela família. <br><br><br>

**Persona 3:** Carlos é veterinário, casado, tem filhos, é proprietário de um hotel especializado para cães e faz plantões em clínicas veterinárias. Portanto, tem a rotina diaria bem agitada e em alguns dias, incerta.<br><br>
* **Necessidades:** Separar e centralizar o registro de alimentação dos cães em um portal feito especialmente para isto, de modo que possa verificar quais os animais que foram alimentados, por quem e quando (Dia e horário); ou se algum animal não foi alimentado.<br><br>
* **Frustrações:** Como não tem muito tempo para estar presente no hotel para cães, Carlos tende a administrá-la à distância, através de ligações, grupos de Whats App e câmeras de segurança instaladas no hotel. Porém, o registro de alimentação dos animais tende a ser complexo, junto ao emaranhado de informações trocadas entre ele e seus colaboradores.



## Histórias de Usuários

A partir da compreensão do dia a dia das personas identificadas para o projeto, foram registradas as seguintes histórias de usuários.

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE`   |PARA ... `MOTIVO/VALOR`                 |
|--------------------|--------------------------------------|----------------------------------------|
| Sandra | Organizar horários de alimentação. Segurança do funcionamento das notificações. Interface personalizável. | Garantir o bem estar e saúde de seu animal |
| Gisele Medeiros |Compartilhar lembretes com a família. Lembrar os filhos de alimentarem o cachorro. | Garantir que o animal seja alimentado. Educar seus filhos quanto a responsabilidades com os cuidados com o cãozinho. |
| Carlos | Separar e centralizar o registro de alimentação dos cães em um portal  especializado. |  Verificar quais os animais que foram alimentados, por quem e quando (Dia e horário). Verificar se algum animal não foi alimentado. |

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

<img src="img/Casos de Uso - 001.jpg" >
Figura 1. Usuário cria sua conta e efetua seu login.


<img src="img/Casos de Uso - 002.jpg" >
Figura 2. Dentro do sistema, o usuário que cadastra o cão torna-se o usuário principal,
outros possíveis responsáveis, serão secundários, receberão notificações e poderão registrar
a alimentação do cão cadastrado.


<img src="img/Casos de Uso - 003.jpg" >
Figura 3. Ao registrar a alimentação será alterado o estado de alimentação
e registrado no histórico de alimentação.
