Feature: 01_Login
	Use before title fiture separed with "-":
	 'C' for Chrome;
	 'I' for Internet Explorer;
	 'F' for FireFox Mozilla;
	 'E' for Edge;
	 'H' for Headless Chrome;
	 Default: Chrome

@01_AcessarPagina
Scenario: 01 Acessar o endereco
Given Acessar o endereco "http://testes.fundacred.org.br/estudante-web/#/"	
Then Validar o carregamento

#DEFINIR O CPF E A SENHA SEPARADOS POR VÍRGULA EX. "11122233344,SENHA"
@02_RealizarLogin
Scenario: 01 Realizar login
Given Clico no botao Entrar
When Preencho os campos nome e senha "556.139.510-63,teste123"
And Clico em Entrar
Then Login deve ser ralizado com sucesso
