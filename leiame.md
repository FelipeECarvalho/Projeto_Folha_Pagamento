# Projeto folha de pagamento
Projeto PIM 4º semestre. O objetivo desse PIM é a criação de um programa que tem como principal objetivo a criação de folhas de pagameto. O software também permite o gerenciamento de colaboradores e empresas.
O programa está disponível para as seguintes plataformas: <strong>Web</strong>, <strong>Windows forms</strong> e <strong>Android</strong>.

Como executar o programa:

1º Crie uma nova conexão no banco de dados com os seguintes dados: "uid = sa", "password = uip@123456", "server = localhost". Depois de criada a conexão, será necessário a criação de um novo banco de dados: recursos_humanos_db.

  1.1° Execute no seu banco de dados o script no que está dentro dos arquivos do programa:
  <br>
  https://imgur.com/a/p2HpmJO
  <br>


2º Para executar o programa será preciso, primeiro, iniciar a API:
  <br>
https://imgur.com/a/1hKCbGd
<br>

3º Como executar o projeto Windows Forms.

  3.1º. Clique com o botão direito no projeto windowsforms, e, após clique em "Debug" -> "Start New Instance"
<br>
https://imgur.com/a/cwG5r4o
<br>

4º Como executar o projeto WEB.

  4.1º. Clique com o botão direito no web, e, após clique em "Debug" -> "Start New Instance"
<br>
https://imgur.com/a/JdfejHk
<br>

5º Como executar o projeto APP.

  5.1º. Abra o Android Studio e carregue o projeto.
  5.2º Após carregar o projeto procure a pasta Conexao. app/java/com.exemple.myapplication/DAL/Conexao
  <br>
  https://imgur.com/a/Elo5eQR
  <br>

  5.3º Dentro da classe Conexao, mude as variáveis de acordo com a conexão do seu banco de dados. Mude também a variável IP para seu próprio ip
    5.4º Para conseguir seu IP, basta abrir o CMD e digitar ipconfig, depois copie o ip que fica em Endereço IPv4 - ex:  Endereço IPv4. . . . . . . .  . . . . . . . : 192.168.0.9
  <br>
  https://imgur.com/a/FTqaHNb
  <br>

  5.5º Depois de ajustada a conexão, basta iniciar o APP

  https://imgur.com/a/CEV1lda
