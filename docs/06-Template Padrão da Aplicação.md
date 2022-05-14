# Template Padrão da Aplicação

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>

Layout padrão da aplicação que será utilizado em todas as páginas com a definição de identidade visual, aspectos de responsividade e iconografia.

## Guia de Estilos
Antes de definir o template da aplicação, foi necessário definir uma guia de estilos com todos os padrões que serão utilizados durante o desenvolvimento do projeto. Estão detalhados nos itens a seguir:

### Paleta de Cores

Paleta de ocres conta com a cor primaria azul, foi definida como cor base a cor rosa em diferentes tonalidades e também o azul e cinza como cores secundárias conforme Figura 19:

![](https://github.com/ICEI-PUC-Minas-PMV-ADS/hora_do_banho/blob/main/docs/img/Paleta%20de%20cores.png)
Figura 19 – Paleta de Cores


As cores foram escolhidas de acordo com o que queremos passar com a nossa aplicação dando evidencias ao cuidado, amor e saúde dos pets.

Usamos tons de verde que tem relação com conceitos de saúde, ambiente calmo e tranquilo, os tons de rosa para se referir ao amor e ternura e o azul que está 
relacionado a tranquilidade e harmonia.

### Tipografia
As fontes utilizadas na aplicação são Montserrat e Rubik, e seguem as seguintes definições de tamanho e estilização, como pode ser observado na Figura 20:

![](https://github.com/ICEI-PUC-Minas-PMV-ADS/hora_do_banho/blob/main/docs/img/Tipografia%20(1).png)
Figura 20 – Tipografia e Fontes utilizadas


### Componentes
Dentre nossos principais componentes personalizados estão os botões e inputs, conforme pode ser visto na Figura 21:

![](https://github.com/ICEI-PUC-Minas-PMV-ADS/hora_do_banho/blob/main/docs/img/Bot%C3%B5es.png)
Figura 21 – Principais componentes visuais da aplicação

### Ícones

![](https://github.com/ICEI-PUC-Minas-PMV-ADS/hora_do_banho/blob/main/docs/img/Icons.png)
Figura 22 – Iconografia


## Aplicação nas telas e fluxos:

### Tela - LandingPage / Login 

A tela inicial ou LandingPage apresentada na *Figura 23* permite visualizar depoimentos e informações sobre os serviços e ao clicar no icon entrar abre um modal conforme explicado no tópico *Modal - Login* que segue. 

![](https://github.com/ICEI-PUC-Minas-PMV-ADS/hora_do_banho/blob/main/docs/img/Home.png)
Figura 23 – LandingPage

### Modal - Login 
O modal que se abre ao clicar no icon entrar no canto superior direito do cabeçalho permite ao usuário fazer login na aplicação, preenchendo suas credenciais conforme orientado. Além disso, o usuário pode ser direcionado para se cadastrar na opção “ Ainda não tem uma conta?” e para redefinir a senha da conta na opção "Esqueci a senha". O modal em questão pode ser visualizado conforme *Figura 24*.

![](https://github.com/ICEI-PUC-Minas-PMV-ADS/hora_do_banho/blob/main/docs/img/Login.png)
Figura 24 – Modal Login

### Fluxo de Telas - Cadastro de Usuário 
O fluxo de *Cadastro de Usuário* ilustrado na *Figura 25* permite ao usuário se cadastrar na aplicação caso este ainda não possua uma conta, seguindo um formulário solicitando informações obrigatórias de acordo com o tipo de perfil a ser criado.

![](https://github.com/ICEI-PUC-Minas-PMV-ADS/hora_do_banho/blob/main/docs/img/Cadastro.jpeg)
Figura 25 – Fluxo de Cadastro de Usuário.

## Fluxo de Telas - Redefinição de senha 
Caso o usuário já possua uma conta mas não saiba sua senha, é permitido que ele altere sua senha por meio do fluxo apresentado nas *Figuras 26 e 27*. 
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/hora_do_banho/blob/main/docs/img/Resetar%20Senha1.png)
Figura 26 – Fluxo de Telas de Redefinição de Senha 

![](https://github.com/ICEI-PUC-Minas-PMV-ADS/hora_do_banho/blob/main/docs/img/Resetar%20Senha2.png)
Figura 27 – Fluxo de Telas de Redefinição de Senha 
