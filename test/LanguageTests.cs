using System;
using Xunit;
using Language;

namespace Tests
{
    public class LanguageTests
    {
        [Fact]
         public void TestFrench() {
             Assert.Equal("Bonjour le monde", new Localise().Translate("fr"));
         }
    }
}
