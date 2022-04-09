# Plano de Testes de Software


| Caso de teste | CT-01-Cadastro do Usuário |
|      ---      |           ---             |
|**Requisitos Associados** | RF-01- A página inicial da aplicação deve possibilitar ao usuário fazer login e se cadastrar. RF-02 – O site deve conter um formulário de cadastro para novos usuários contendo a intenção de cadastro desejada.
|**Entrada Cadastro**| Preencher E-mail, Nome, Sobrenome, CEP, Celular, crie uma senha.
|**Login**| Informar o E-mail e a Senha.
|**Objetivo do Teste**| Permitir que o usuário crie um cadastro no site.
|**Passos**| 1- Acessar o Navegador, 2- Informar o endereço do Site, 3- Clicar no botão Cadastrar, 4- Preencher os campos com as informações válidas, 5- Clicar no botão confirmar Cadastro.
|**Critérios de Êxito**|Cliente redirecionado para a página de login, com a seguinte mensagem: “Cadastro realizado com sucesso!”





|**Caso de teste**| CT-02 – Login de usuário |
|     ---     |           ---            |
|**Requisitos Associados**|RF-03 – A página inicial da aplicação deve possibilitar ao usuário fazer login e se cadastrar.
|**Entrada Login**| Após preencher o e-mail e senha.
|**Objetivo do teste**|Permitir que o usuário acesse a plataforma através do Login
|**Passos**| 1- Acessar o navegador, 2- Informar o endereço do Site, 3- Clicar no botão no canto superior direito em “Entrar”, 4- Preencher os campos com informações válidas, 5- Clicar no botão “Confirmar Login”.
|**Critérios de Êxito**|Usuário será direcionado a Home Page e terá acesso as funcionalidades da página.





|**Caso de teste**| CT-03 Tela Principal|
|       ---       |         ---         |
|**Requisitos Associados**| RF-04 – A aplicação deverá permitir que o usuário visualize uma lista de produtos, serviços oferecidos pelos Petshops e informações sobre os serviços.
|**Entrada**| Acessar a tela inicial.
|**Objetivo do teste**|Disponibilizar ao usuário informações sobre os serviços prestados pelos Petshops
|**Passos**| 1- Acessar o navegador, 2- Informar o endereço do Site, 3- Visualizar a página inicial.
|**Critérios de Êxito**|Visualizar os serviços e as Informações dos serviços disponíveis no site.




|**Caso de Teste**| CT-04 – Alterar senha|
|       ---       |         ---          |
|**Requisitos Associados**| RF-05 – O site deve conter um formulário que permita o usuário criar uma nova senha em caso de esquecimento.
|**Entrada**| Após clicar no botão “Esqueci minha Senha”, o usuário deverá informar seu e-mail cadastrado para criar uma nova senha
|**Objetivo do Teste**| Verificar se o cliente consegue realizar a alteração da senha de login no site.
|**Passos**| 1- Acessar o navegador, 2- Informar o endereço do site, 3- Visualizar a página principal, 4- Clicar no link “Esqueci minha senha”, 5- Informar o e-mail, onde o cliente será redirecionado para a criação de uma nova senha, 6- Insira a nova senha no campo (Senha) e redigite no campo (Confirmar senha) e clique no botão Enviar, cliente será redirecionado a tela de Login.
|**Critérios de Êxito**| Mensagem “Senha alterada com sucesso.”







|**Casos de Teste**| CT-05-Cadastro do Petshop |
|      ---       |            ---            |
|**Requisitos Associados**| RF-06 - A página inicial deve permitir ao representante do Petshop efetuar seu cadastro no site. RF-02- O site deve conter um formulário de cadastro pra novos usuários contendo a intenção de cadastro desejada.
|**Entrada cadastro**| Preencher: E-mail, Nome fantasia, Razão Social, CNPJ, Telefone, Crie sua senha e confirme a senha.
|**Login**| Informar email e senha cadastrados.
|**Objetivo do teste**| Permitir que o usuário crie um cadastro do seu Petshop.
|**Passos**| 1-Acessar o navegador, 2- Informar o endereço do site, 3- Clicar no botão cadastrar, 4- preencher os campos de cadastro, 5- Clicar no botão concluir cadastro.
|**Critérios de Êxito**| Usuário será redirecionado a página de login, e receberá a mensagem "Cadastro efetuado com sucesso!"






| Casos de teste | CT-06-Agenda |
|      ---       |        ---        |
|**Requisitos Associados**| RF-07 - A página deve permitir ao usuário realizar uma busca por um petshop e verificar as datas disponíveis para realizar um agendamento.
|**Entrada Agendamento**| Informar um petshop cadastrado no site
|**Objetivo do teste**| Permitir que o cliente visualize as datas disponíveis para agendamento.
|**Passo**| 1- Acessar o navegador, 2- Informar o endereço so site, 3- Clicar no botão "Pesquisar Petshop", 4- Preencher os campos obrigatórios para o agendamento, 5- Selecionar uma data disponível.
|**Critérios de Êxito**| O usuário será redirecionado para a página de agendamento.





| Casos de teste | CT-07-Agendamento |
|      ---       |        ---        |
|**Requisitos Associados**| RF-08 - A página deve permitir ao usuário realizar o agendamento dos serviços prestados pelo Petshop.
|**Entrada Agendamento**| Preencher: Pet, Serviço, Profissional, Petshop, Serviços Adicionais.
|**Objetivo do teste**| Permitir que o cliente agende um horário para prestação de serviço ao Pet.
|**Passo**| 1- Acessar o navegador, 2- Informar o endereço so site, 3- Preencher os campos obrigatórios, 4- Preencher os campos obrigatórios para o agendamento, 5- Adicionar um serviço adicional, caso o cliente queira, 6- Clicar no botão "Concluir".
|**Critérios de Êxito**| O usuário será redirecionado para a página da Agenda.

