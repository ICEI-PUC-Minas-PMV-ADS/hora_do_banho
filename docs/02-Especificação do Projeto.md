# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foi consolidada com a participação dos usuários em um trabalho de imersão feita pelos membros da equipe a partir da observação dos usuários em seu local natural e por meio de entrevistas. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários. 

## Personas

|**Oscar Gabriel Braga**|||
|:----------------------------------------------------------------------------------------------------------------:|:---:|:---:|
|<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/hora_do_banho/blob/main/docs/img/persona%201.jpg" width="150">|<p>**Idade**: 42 anos</p> <p>**Ocupação**: Enfermeiro</p>|**Aplicativos**: Instagram, Facebook, Youtube |
|**Motivações**: Cuidar de pessoas, família.|**Frustrações**: Buscar por serviços que possam atender suas necessidades de última hora ou em um curto prazo. |**Hobbies**: Viajar, ler, lazer com a família. |

|**Pamela Viana**|||
|:---:|:---:|:---:|
|<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/hora_do_banho/blob/main/docs/img/persona%202.jpg" width="150">|<p>**Idade**: 34 anos</p> <p>**Ocupação**: Médica Veterinária</p>|**Aplicativos**: Instagram, Facebook, LinkedIn, Youtube |
|**Motivações**: Flexibilidade de horários, "ganhar tempo". |**Frustrações**: Não conseguir dar conta de todas as tarefas do dia a dia. |**Hobbies**: Podcasts, livros, passear com os cachorros. |

|**João da Silva**|||
|:---:|:---:|:---:|
|<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/hora_do_banho/blob/main/docs/img/persona%204.jpg" width="150">|<p>**Idade**: 38 anos</p> <p>**Ocupação**:  Proprietário do Pet Shop Auquimia</p>|**Aplicativos**: Instagram e Facebook.  |
|**Motivações**: Aumentar o faturamento de seu negócio.  |**Frustrações**: Não conseguir atingir todos os seus clientes potenciais.  |**Hobbies**: Estudar, ler, assistir séries e viajar.|

|**Joana Oliveira**|||
|:---:|:---:|:---:|
|<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/hora_do_banho/blob/main/docs/img/persona%203.jpg" width="150">|<p>**Idade**: 45 anos</p> <p>**Ocupação**:  Proprietário do Pet 4 Patas</p>|**Aplicativos**: Instagram e Youtube.  |
|**Motivações**: Expandir o negócio e potencializar a divulgação dos serviços prestados.  |**Frustrações**: Loja não fica em um ponto com boa visibilidade.   |**Hobbies**: Praticar esportes|

## Histórias de Usuários

A partir da compreensão do dia a dia das personas identificadas para o projeto, foram registradas as seguintes histórias de usuários. 

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Oscar Gabriel Braga | Visualizar Petshops pertos da minha casa | Não perder tempo com locomoção |
|Oscar Gabriel Braga | Agendar horário em petshop atráves de um site | Não usar o pouco tempo livre que tenho no dia ligando para petshop para marcar horário |
|Pamela Viana | Não ter que ligar com antecedência para Pet Shops para marcar banho e tosa para os meus cachorros | Quando ocorrer de esquecer de marcar horário, conseguir achar agenda disponível de forma prática |
|Pamela Viana | Uma ferramenta que me ajude a conhecer os serviços de banho e tosa da região. | Conhecer, pois me mudei há pouco tempo para a região |
|João da Silva | Um site em que eu possa disponibilizar meus serviços | Para aumentar o alcance do meu serviço |
|João da Silva | Quero um sistema que gere as informações dos meus clientes | Me organizar de melhor forma a não perder informações e históricos dos clientes |
|Joana Oliveira | Expandir meu negócio na internet | Para atender de forma mais cômoda os clientes |
|Joana Oliveira | Aumentar o volume de venda de serviço de forma eficiente | Para poder me adequar ao mercado digital e trazer mais clientes para a loja |

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O Sistema deve permitir o acesso ao login pelo cliente e pelo proprietário de Pet Shop.| ALTA |
|RF-002| O Sistema deve permitir ao pet shop gerenciar seus dados de cadastro. | ALTA | 
|RF-003| O Sistema deve permitir ao cliente gerenciar seus dados pessoais. | ALTA | 
|RF-004| O Sistema deve permitir ao cliente a visualização de datas disponiveis e preços pré estabelicidos de acorco com o tipo serviço para o agendamento. | ALTA | 
|RF-005| O Sistema deve permitir o cadastro de agenda de datas disponíveis e indisponíveis dos Pet Shops e dos preços dos serviços pré-definidos. | ALTA | 
|RF-006| O Sistema deve permitir ao cliente consultar dados (nome, telefone, endereço) dos Pet Shops.| ALTA | 
|RF-007| O Sistema deve permitir ao cliente solicitar agendamento de horário(s) para serviço(s). | ALTA | 
|RF-008| O Sistema deve permitir ao proprietário de Pet Shop visualizar solicitações de agendamento, confirmando-os ou não. | ALTA | 
|RF-009| O Sistema deve fornecer ao cliente uma mensagem de confirmação do agendamento. | BAIXA |
|RF-010| O Sistema deve permitir ao cliente consultar seu(s) agendamento(s) confirmado(s) e permitir o cancelamento do serviço. | ALTA | 
|RF-011| O Sistema deve permitir ao proprietário de Pet Shop visualizar lista de agendamentos confirmados. | ALTA | 
|RF-012| O Sistema deve notificar ao Pet Shop a solicitação de agendamento enviada pelo cliente. | ALTA |
 
### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser implementado na linguagem C#, html, CSS e Java Script. | ALTA | 
|RNF-002| As informações de cadastro devem ficar disponíveis apenas para os clientes, para os proprietários de Pet Shops e para a plataforma. | ALTA |
|RNF-003| O site deve estar disponível para os principais navegadores: Chrome, Firefox, Edge. | ALTA |
|RNF-004| O sistemae deve estar disponivel 24 horas por dia, os sete dias da semana. | ALTA |
|RNF-005| O site deve ser responsivo, compatível a qualquer tipo de aparelho. Ex: Notebook, tablet, celular. | ALTA |
|RNF-006| O sistema deve enviar para o cliente a confirmação via sms.| BAIXA |
|RNF-007| O sistema deve oferecer classificação de qualidade de 1 a 5 estrelas de pet shops e usuários. | BAIXA |

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deve ser entregue ao final do semestre, não ultrapassando a data limite de 26/06/2022.|
|02| O projeto deve ser desenvolvido em html, CSS, Java Script e C#.|
|03| O projeto deve ser realizado pela equipe formada sem interferências externas. |

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos.

|**ATOR**|**DESCRIÇÃO**|
|---|---|
|Cliente|Pessoa interessada no serviço de marcação de banho e/ou tosa para o seu animal de estimação.|
|Proprietário do Pet Shop|Pessoa proprietária do Pet Shop, o qual fornecerá os serviços de banho e/ou tosa.|

|**CASO DE USO**|**DESCRIÇÃO**|**RF**|
|---|---|---|
|Fazer login.|O Sistema deve permitir o acesso ao login pelo cliente e pelo proprietário de Pet Shop.|RF-001|
|Gerenciar dados do Pet Shop.|O Sistema deve permitir ao pet shop gerenciar seus dados de cadastro.|RF-002|
|Gerenciar dados pessoais.|O Sistema deve permitir ao cliente gerenciar seus dados pessoais.|RF-003| 


<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/hora_do_banho/blob/main/docs/img/Diagrama%20de%20Casos%20de%20Uso.png">
