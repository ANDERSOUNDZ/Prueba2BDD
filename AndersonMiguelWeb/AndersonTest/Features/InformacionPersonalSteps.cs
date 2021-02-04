using AndersonMiguelBiblioteca;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace AndersonMiguelWeb.Features
{
    [Binding]
    public class InformacionPersonalSteps
    {
        IWebDriver driver = new FirefoxDriver();
        public InformacionPersonalSteps()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        Profesor profesor = new Profesor();
        [Given(@"que un profesor tiene (.*)")]
        public void DadoQueUnProfesorTiene(string nombre)
        {
            driver.Navigate().GoToUrl("https://localhost:44379/");
            profesor.Nombre = nombre;
        }
        
        [Given(@"tambien (.*)")]
        public void DadoTambien(string apellido)
        {
            profesor.Apellido = apellido;
        }
        
        [When(@"ingresan los datos")]
        public void CuandoIngresanLosDatos()
        {
            profesor.IngresaDatos();
        }
        
        [Then(@"se almacenan los datos (.*) (.*)")]
        public void EntoncesSeAlmacenanLosDatos(string nombre, string apellido)
        {
            Assert.AreEqual(nombre, profesor.Nombre);
            Assert.AreEqual(apellido, profesor.Apellido);
        }
    }
}
