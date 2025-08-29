using MaterialSkin;
using MaterialSkin.Controls; 
using System;
using System.Drawing;

namespace DSDIIPamonharia.UI.Classes
{
    internal class ThemeConfig
    {
        public static void ApplyTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;

            // Paleta "Verde e Amarelo" (Natural e Vibrante)
            // Cor Primária (base, barra de título): Verde da palha
            var primaryColor = ColorTranslator.FromHtml("#4CAF50");

            // Cor Primária Escura (barra de status): Verde mais escuro
            var darkPrimaryColor = ColorTranslator.FromHtml("#388E3C");

            // Cor Primária Clara (para efeitos de hover/foco): Amarelo do milho
            var lightPrimaryColor = ColorTranslator.FromHtml("#FFC107");

            // Cor de Destaque (botões, seleções): Amarelo do milho
            var accentColor = ColorTranslator.FromHtml("#FFC107");

            // Cor do texto sobre as cores primárias (o verde é escuro, então o texto é branco)
            var textShade = TextShade.WHITE;

            // Definir o tema
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; // Fundo geral da janela será claro
            materialSkinManager.ColorScheme = new ColorScheme(
                primaryColor,
                darkPrimaryColor,
                lightPrimaryColor,
                accentColor,
                textShade
            );
        }
    }
}