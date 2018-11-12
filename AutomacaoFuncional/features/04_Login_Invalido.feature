Feature: 04_Login_Invalido
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@01_AcessarPagina
Scenario: 01 Acessar o endereco
Given Acessar o endereco "http://homologacao.fundacred.org.br/estudante-web/#/"	
Then Validar o carregamento

@02_RealizarLogin
Scenario: 01 Validar Senha Incorreta
Given Clico no botao Entrar
When Preencho o campo usuario "556.139.510-63"
And Clico em Entrar
Then Validar mensagem de senha incorreta
