# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foi consolidada com a participação dos usuários em um trabalho de imersão feita pelos membros da equipe a partir da observação dos usuários em seu local natural e por meio de entrevistas. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários. 

## Personas

|**Oscar Gabriel Braga**|||
|:----------------------------------------------------------------------------------------------------------------:|:---:|:---:|
|<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/hora_do_banho/blob/main/docs/img/persona%201.jpg" width="150">|**Idade**: 42 anos 
**Ocupação**: Enfermeiro|**Aplicativos**: Instagram, Facebook, Youtube |
|**Motivações**: Cuidar de pessoas, família |**Frustrações**: Buscar por serviços que possam atender suas necessidades de última hora ou em um curto prazo. |**Hobbies**: Viajar, ler, lazer com a família. |

|**Pamela Viana**|||
|:---:|:---:|:---:|
|<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/hora_do_banho/blob/main/docs/img/persona%202.jpg" width="150">|**Idade**: 34 anos **Ocupação**: Médica Veterinária|**Aplicativos**: Instagram, Facebook, LinkedIn, Youtube |
|**Motivações**: Flexibilidade de horários, "ganhar tempo". |**Frustrações**: Não conseguir dar conta de todas as tarefas do dia a dia. |**Hobbies**: Podcasts, livros, passear com os cachorros. |

|**João da Silva**|||
|:---:|:---:|:---:|
|<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/hora_do_banho/blob/main/docs/img/persona%204.jpg" width="150">|**Idade**: 38 anos **Ocupação**:  Proprietário do Pet Shop Auquimia|**Aplicativos**: Instagram e Facebook.  |
|**Motivações**: Aumentar o faturamento de seu negócio.  |**Frustrações**: Não conseguir atingir todos os seus clientes potenciais.  |**Hobbies**: Estudar, ler, assistir séries e viajar.|

|**Joana Oliveira**|||
|:---:|:---:|:---:|
|<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/hora_do_banho/blob/main/docs/img/persona%203.jpg" width="150">|**Idade**: 45 anos **Ocupação**:  Proprietário do Pet 4 Patas|**Aplicativos**: Instagram e Youtube.  |
|**Motivações**: Expandir o negócio e potencializar a divulgação dos serviços prestados.  |**Frustrações**: Loja não fica em um ponto com boa visibilidade.   |**Hobbies**: Praticar esportes|

> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>

## Histórias de Usuários

A partir da compreensão do dia a dia das personas identificadas para o projeto, foram registradas as seguintes histórias de usuários. 

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Oscar Gabriel Braga | Visualizar Petshops pertos da minha casa | Não perder muito tempo de locomoção |
|Oscar Gabriel Braga | Um site em que eu possa fazer agendamentos em petshop | Quero uma certa comodidade, já que eu não tenho tanto tempo sobrando no dia a dia |
|Pamela Viana | Não ter que ligar com antecedência para Pet Shops para marcar banho e tosa para os meus cachorros | Sempre me esqueço de ligar, só faço no momento que preciso. |
|Pamela Viana | Uma ferramenta que me ajude a conhecer os serviços de banho e tosa da região. | Me mudei há pouco tempo, e não conheço o bairro. |
|João da Silva | Gostaria de ter um site em que eu possa disponibilizar meus serviços | Para que meu estabelecimento tenha mais visibilidade |
|João da Silva | Quero um sistema que gere as informações dos meus clientes | Me organizar de melhor forma a não perder informações e históricos dos clientes |
|Joana Oliveira | Expandir meu negócio na internet | Para atender de forma mais cômoda os clientes |
|Joana Oliveira | Quero ter um volume de vendas maior e de forma eficiente | Para poder me adequar ao mercado digital e trazer mais clientes para a loja |

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O Sistema deve permitir o acesso ao login pelo cliente e pelo proprietário de Pet Shop.| ALTA |
|RF-002| O Sistema deve permitir ao pet shop gerenciar seus dados de cadastro. | ALTA | 
|RF-003| O Sistema deve permitir ao cliente gerenciar seus dados pessoais. | ALTA | 
|RF-004| O Sistema deve permitir ao cliente a visualização de datas disponiveis e preços para o agendamento do serviço. | ALTA | 
|RF-005| O Sistema deve permitir o cadastro de agenda de datas disponíveis e indisponíveis dos Pet Shops e dos preços dos serviços. | ALTA | 
|RF-006| O Sistema deve permitir ao cliente consultar dados (nome, telefone, endereço) dos Pet Shops.| ALTA | 
|RF-007| O Sistema deve permitir ao cliente solicitar agendamento de horário(s) para serviço(s). | ALTA | 
|RF-008| O Sistema deve permitir ao proprietário de Pet Shop visualizar solicitações de agendamento, confirmando-os ou não. | ALTA | 
|RF-009| O Sistema deve fornecer ao cliente uma mensagem de confirmação do agendamento por SMS. | BAIXA |
|RF-010| O Sistema deve permitir ao cliente consultar seu(s) agendamento(s) confirmado(s) e/ou a confirmar. | ALTA | 
|RF-011| O Sistema deve permitir ao proprietário de Pet Shop visualizar lista de agendamentos confirmados. | ALTA | 
|RF-012| O Sistema deve notificar ao Pet Shop a solicitação de agendamento enviada pelo cliente. | ALTA |
 
### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser implementado na linguagem C#, html, CSS e Java Script. | ALTA | 
|RNF-002| As informações de cadastro do cliente devem ficar disponiveis apenas para os clientes e para a plataforma. | ALTA |
|RNF-003| O site deve estar disponível para os principais navegadores: Chrome, Firefox, Edge. | ALTA |
|RNF-004| O sistemae deve estar disponivel 24 horas por dia, os sete dias da semana. | ALTA |
|RNF-005| O site deve ser responsivo, compativel a qualquer tipo de aparelho. Ex: Notebook, tablet, celular. | ALTA |

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deve ser entregue ao final do semestre, não ultrapassando a data limite de 26/06/2022.|
|02| O projeto deve ser desenvolvido em html, CSS, Java Script e C#.|
|03| O projeto deve ser realizado pela equipe formada sem interferências externas. |

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/hora_do_banho/blob/main/docs/img/Projeto%20Eixo%202%20-%20Diagrama%20de%20Casos%20de%20Uso%20.png">


> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
