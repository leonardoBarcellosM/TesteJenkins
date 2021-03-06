﻿using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{

    [Binding]
    public class IniciarFluxoComeceAgoraSteps
    {
        private IniciarFluxoComeceAgoraActions pageAction = new IniciarFluxoComeceAgoraActions();

        [Given(@"Preencher os dados")]
        public void GivenPreencherOsDados()
        {
            bool result = pageAction.PreencherOsDados();

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True, "Erro ao preencher os dados!");
            });
        }

        [When(@"Clicar em Comece agora sem compromisso")]
        public void WhenClicarEmComeceAgoraSemCompromisso()
        {
            bool result = pageAction.ClicarComeceAgora();

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True, "Erro ao clicar em comece agora!");
            });
        }

        [Then(@"Validar se o fluxo e iniciado")]
        public void ThenValidarSeOFluxoEIniciado()
        {
            var result = pageAction.FluxoIniciadoComSucesso();

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True, "Erro ao iniciar o fluxo Comece Agora Sem Compromisso!");
            });
        }

        
    }
}
