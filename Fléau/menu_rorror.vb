Public Class menu_rorror
    Private Sub input_TextChanged(sender As Object, e As EventArgs) Handles input.TextChanged
        output.Text = input.Text _
                .Replace("a", " ́") _
                .Replace("b", " ̂") _
                .Replace("c", " ̀") _
                .Replace("d", " ̄") _
                .Replace("e", " ̅") _
                .Replace("f", " ̆") _
                .Replace("g", " ̇") _
                .Replace("h", " ̈") _
                .Replace("i", " ̉") _
                .Replace("j", " ̊") _
                .Replace("k", " ̋") _
                .Replace("l", " ̍") _
                .Replace("m", " ̎") _
                .Replace("n", " ̏") _
                .Replace("o", " ̐") _
                .Replace("p", " ̑") _
                .Replace("q", " ̓") _
                .Replace("r", " ̔") _
                .Replace("s", " ̕") _
                .Replace("t", " ̖") _
                .Replace("u", " ̗") _
                .Replace("v", " ̘") _
                .Replace("w", " ̙") _
                .Replace("x", " ̚") _
                .Replace("y", " ̛") _
                .Replace("z", " ̜") _
 _
                .Replace("A", "ᅟ") _
                .Replace("B", "ᅠ") _
                .Replace("C", "ᆞ") _
                .Replace("D", "፝") _
                .Replace("E", "፞") _
                .Replace("F", "፟") _
                .Replace("G", "᠊") _
                .Replace("H", "ᱸ") _
                .Replace("I", "ᱹ") _
                .Replace("J", "ᱺ") _
                .Replace("K", "ᱻ") _
                .Replace("L", "᾽") _
                .Replace("M", "ι") _
                .Replace("N", "῁") _
                .Replace("O", "῝") _
                .Replace("P", "῞") _
                .Replace("Q", "῟") _
                .Replace("R", "`") _
                .Replace("S", "῭") _
                .Replace("T", "‧") _
                .Replace("U", "…") _
                .Replace("V", "‥") _
                .Replace("W", "‾") _
                .Replace("X", "ₛ") _
                .Replace("Y", "∷") _
                .Replace("Z", "⫶") _
 _
                .Replace("é", "ؖ‎") _
                .Replace("è", "ؗ‎") _
                .Replace("ê", "𝅽") _
                .Replace(".", "ؘ‎") _
                .Replace("/", "ؙ‎") _
                .Replace("-", "ؚ‎") _
                .Replace("_", "؛") _
                .Replace("(", "𝆢") _
                .Replace(")", "𝇅") _
                .Replace("!", "𝆁") _
                .Replace("?", "⥽") _
                .Replace("~", "𝇆") _
                .Replace("/", "▵") _
                .Replace(":", "𝅾") _
                .Replace("ç", "┌") _
                .Replace("à", "𝅭") _
                .Replace(",", "⑀") _
                .Replace(";", "⑅") _
                .Replace("§", "⑈") _
                .Replace("&", "⑉") _
                .Replace("@", "𝆌") _
                .Replace("\", "⑆") _
                .Replace("""", "⏓") _
                .Replace("<", "𝅧") _
                .Replace(">", "𝆌") _
                .Replace("^", "𝆝") _
 _
                .Replace("1", "𝄪") _
                .Replace("2", "⍣") _
                .Replace("3", "⍤") _
                .Replace("4", "⍪") _
                .Replace("5", "⍳") _
                .Replace("6", "𝆜") _
                .Replace("7", "𝆯") _
                .Replace("8", "𝆴") _
                .Replace("9", "⌝") _
                .Replace("0", "𝆮")
    End Sub

    Private Sub output_TextChanged(sender As Object, e As EventArgs) Handles output.TextChanged
        input.Text = output.Text _
                .Replace(" ́", "a") _
                .Replace(" ̂", "b") _
                .Replace(" ̀", "c") _
                .Replace(" ̄", "d") _
                .Replace(" ̅", "e") _
                .Replace(" ̆", "f") _
                .Replace(" ̇", "g") _
                .Replace(" ̈", "h") _
                .Replace(" ̉", "i") _
                .Replace(" ̊", "j") _
                .Replace(" ̋", "k") _
                .Replace(" ̍", "l") _
                .Replace(" ̎", "m") _
                .Replace(" ̏", "n") _
                .Replace(" ̐", "o") _
                .Replace(" ̑", "p") _
                .Replace(" ̓", "q") _
                .Replace(" ̔", "r") _
                .Replace(" ̕", "s") _
                .Replace(" ̖", "t") _
                .Replace(" ̗", "u") _
                .Replace(" ̘", "v") _
                .Replace(" ̙", "w") _
                .Replace(" ̚", "x") _
                .Replace(" ̛", "y") _
                .Replace(" ̜", "z") _
 _
                .Replace("ᅟ", "A") _
                .Replace("ᅠ", "B") _
                .Replace("ᆞ", "C") _
                .Replace("፝", "D") _
                .Replace("፞", "E") _
                .Replace("፟", "F") _
                .Replace("᠊", "G") _
                .Replace("ᱸ", "H") _
                .Replace("ᱹ", "I") _
                .Replace("ᱺ", "J") _
                .Replace("ᱻ", "K") _
                .Replace("᾽", "L") _
                .Replace("ι", "M") _
                .Replace("῁", "N") _
                .Replace("῝", "O") _
                .Replace("῞", "P") _
                .Replace("῟", "Q") _
                .Replace("`", "R") _
                .Replace("῭", "S") _
                .Replace("‧", "T") _
                .Replace("…", "U") _
                .Replace("‥", "V") _
                .Replace("‾", "W") _
                .Replace("ₛ", "X") _
                .Replace("∷", "Y") _
                .Replace("⫶", "Z") _
 _
                .Replace("ؖ‎", "é") _
                .Replace("ؗ‎", "è") _
                .Replace("𝅽", "ê") _
                .Replace("ؘ‎", ".") _
                .Replace("ؙ‎", "/") _
                .Replace("ؚ‎", "-") _
                .Replace("؛", "_") _
                .Replace("𝆢", "(") _
                .Replace("𝇅", ")") _
                .Replace("𝆁", "!") _
                .Replace("⥽", "?") _
                .Replace("𝇆", "~") _
                .Replace("▵", "/") _
                .Replace("𝅾", ":") _
                .Replace("┌", "ç") _
                .Replace("𝅭", "à") _
                .Replace("⑀", ",") _
                .Replace("⑅", ";") _
                .Replace("⑈", "§") _
                .Replace("⑉", "&") _
                .Replace("𝆌", "@") _
                .Replace("⑆", "\") _
                .Replace("⏓", """") _
                .Replace("𝅧", "<") _
                .Replace("𝆌", ">") _
                .Replace("𝆝", "^") _
 _
                .Replace("𝄪", "1") _
                .Replace("⍣", "2") _
                .Replace("⍤", "3") _
                .Replace("⍪", "4") _
                .Replace("⍳", "5") _
                .Replace("𝆜", "6") _
                .Replace("𝆯", "7") _
                .Replace("𝆴", "8") _
                .Replace("⌝", "9") _
                .Replace("𝆮", "0")
    End Sub

    Private Sub copy_Click(sender As Object, e As EventArgs) Handles copy.Click
        Clipboard.SetText("```" + Me.output.Text + "```")
        copy.Text = "Copié!"
        Application.DoEvents()
        Threading.Thread.Sleep(1000)
        copy.Text = "Copier"
    End Sub

    Private Sub Coller_Click(sender As Object, e As EventArgs) Handles paste.Click
        Me.output.Text = Clipboard.GetText()
        paste.Text = "Collé!"
        Application.DoEvents()
        Threading.Thread.Sleep(1000)
        paste.Text = "Coller"
    End Sub

    Public Sub reloadColors()
        Me.BackColor = My.Settings.AllBackColor
        input.BackColor = My.Settings.AllForeColor
        output.BackColor = My.Settings.AllForeColor
        copy.BackColor = My.Settings.AllForeColor
        paste.BackColor = My.Settings.AllForeColor
        input.ForeColor = My.Settings.AllTextColor
        output.ForeColor = My.Settings.AllTextColor
        copy.ForeColor = My.Settings.AllTextColor
        paste.ForeColor = My.Settings.AllTextColor
    End Sub
    Private Sub menu_rorror_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadColors()
    End Sub
End Class