﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AutomacaoFuncional.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("03_Validar_Renda_Minima")]
    public partial class _03_Validar_Renda_MinimaFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "03_Validar_Renda_Minima.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "03_Validar_Renda_Minima", "\tIn order to avoid silly mistakes\r\n\tAs a math idiot\r\n\tI want to be told the sum o" +
                    "f two numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("01 Acessar o endereco")]
        [NUnit.Framework.CategoryAttribute("01_AcessarPagina")]
        public virtual void _01AcessarOEndereco()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("01 Acessar o endereco", null, new string[] {
                        "01_AcessarPagina"});
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
testRunner.Given("Acessar o endereco \"http://homologacao.fundacred.org.br/estudante-web/#/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
testRunner.Then("Validar o carregamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("02 Iniciar Fluxo Comece Agora")]
        [NUnit.Framework.CategoryAttribute("Renda_Minima")]
        public virtual void _02IniciarFluxoComeceAgora()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("02 Iniciar Fluxo Comece Agora", null, new string[] {
                        "Renda_Minima"});
#line 12
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 13
testRunner.Given("Preencher os dados", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
testRunner.When("Clicar em Comece agora sem compromisso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
testRunner.Then("Validar se o fluxo e iniciado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("03 Iniciar Solicitacao")]
        [NUnit.Framework.CategoryAttribute("Renda_Minima")]
        public virtual void _03IniciarSolicitacao()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("03 Iniciar Solicitacao", null, new string[] {
                        "Renda_Minima"});
#line 18
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 19
testRunner.Given("Acessar a opcao solicitacao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
testRunner.When("Clicar em quero solicitar o credito", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
testRunner.Then("Validar o direcionamento com sucesso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("04 Selecionar Instituicao")]
        [NUnit.Framework.CategoryAttribute("Renda_Minima")]
        public virtual void _04SelecionarInstituicao()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("04 Selecionar Instituicao", null, new string[] {
                        "Renda_Minima"});
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 25
testRunner.Given("Selecionar instituicao \"PUCRS (GRADUACAO)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
testRunner.When("Selecionar curso \"ADMINISTRACAO DE EMPRESAS\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
testRunner.And("Clicar no botao aceito os termos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
testRunner.Then("Validar solicitacao enviada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("05 Preencher Dados Do Estudante")]
        [NUnit.Framework.CategoryAttribute("Renda_Minima")]
        public virtual void _05PreencherDadosDoEstudante()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("05 Preencher Dados Do Estudante", null, new string[] {
                        "Renda_Minima"});
#line 31
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 32
testRunner.Given("Inserir o numero de integrantes da familia \" 2 \"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
testRunner.When("Inserir a renda bruta mensal \" 4.000,00 \"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
testRunner.Given("Clicar no botao enviar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 35
testRunner.Then("Validar direcionamento para etapa 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("06 Validar Renda Minima")]
        [NUnit.Framework.CategoryAttribute("Renda_Minima")]
        public virtual void _06ValidarRendaMinima()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("06 Validar Renda Minima", null, new string[] {
                        "Renda_Minima"});
#line 38
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 39
testRunner.Given("Verifico a mensagem renda minima \"3.808,14.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 40
testRunner.When("Informo renda inferior \" 3.808,13 \"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
testRunner.And("valido a mensagem apresentada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
testRunner.Then("Valido botão enviar desabilitado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("07 Validar Botao Continuar")]
        [NUnit.Framework.CategoryAttribute("Renda_Minima")]
        public virtual void _07ValidarBotaoContinuar()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("07 Validar Botao Continuar", null, new string[] {
                        "Renda_Minima"});
#line 45
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 46
testRunner.Given("Verifico o botão apresentado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 47
testRunner.When("clico no botão", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
testRunner.Then("Valido botao enviar habilitado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("08 Validar Renda Superior")]
        [NUnit.Framework.CategoryAttribute("Renda_Minima")]
        public virtual void _08ValidarRendaSuperior()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("08 Validar Renda Superior", null, new string[] {
                        "Renda_Minima"});
#line 51
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 52
testRunner.Given("Informo renda superior \"3.808,14\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 53
testRunner.When("Valido a mensagem", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
testRunner.Then("Valido botao enviar habilitado renda valida", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("09 Validar Renda minima para fiador vinculado")]
        [NUnit.Framework.CategoryAttribute("Renda_Minima")]
        public virtual void _09ValidarRendaMinimaParaFiadorVinculado()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("09 Validar Renda minima para fiador vinculado", null, new string[] {
                        "Renda_Minima"});
#line 57
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 58
testRunner.Given("Informo cpf \"00008131090\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 59
testRunner.Then("Valido a mensagem \"6.454,54.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion