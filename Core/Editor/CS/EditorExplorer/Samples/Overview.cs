﻿using System;
using System.Windows.Forms;
using System.IO;
using C1.Win.Editor;
using C1.Win.Editor.Ribbon;
using C1.Win.Ribbon;
using C1.Win.Themes;

namespace EditorExplorer.Samples
{
    public partial class Overview : UserControl
    {
        public Overview()
        {
            InitializeComponent();
            RibbonTheming.AddTheming(c1EditorRibbon1);
            c1Editor1.C1EditorReady += c1Editor1_C1EditorReady;
        }

        private void c1Editor1_C1EditorReady(object sender, EventArgs e)
        {
            string filename = @"Resources\tesla.html";
            if (File.Exists(filename))
            {
                c1Editor1.LoadDocument(Path.GetFullPath(filename));
                c1Editor1.SetDefaultStyles(null, true);
            }
        }

        private class RibbonTheming
        {
            private readonly RibbonComboBox themeBox;
            public RibbonTheming(C1EditorRibbon editorRibbon)
            {
                // Add theme combobox to the ribbon.
                themeBox = new RibbonComboBox();
                themeBox.TextAreaWidth = 200;
                themeBox.SelectedIndexChanged += (o, e) =>
                {
                    if (themeBox is not null)
                    {
                        var theme = C1ThemeController.GetThemeByName(themeBox.SelectedItem.Text, false);
                        if (theme is null)
                            C1ThemeController.ApplyThemeToControlTree(editorRibbon.Parent, null);
                        else
                            theme.ApplyThemeToControlTree(editorRibbon.Parent);
                    }
                };

                themeBox.Items.Clear();
                string[] themes = C1ThemeController.GetThemes();
                themeBox.Items.Add("(No Theme)");
                foreach (string t in themes)
                    themeBox.Items.Add(t);
                themeBox.SelectedIndex = 0;

                var toolbar = editorRibbon.TopToolBar;
                toolbar.Visible = true;
                toolbar.Items.Add(themeBox);
            }

            public static void AddTheming(C1EditorRibbon editorRibbon)
            {
                new RibbonTheming(editorRibbon);
            }
        }
    }
}