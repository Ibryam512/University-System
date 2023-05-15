using System.Runtime.CompilerServices;

namespace UniSystem
{
    public static class Validator
    {
        private static Dictionary<TextBox, Label> validateMessages = new Dictionary<TextBox, Label>();

       public static void Validate(this TextBox textBox, int minLength = -1, int maxLength = -1, string customMessage = "")
        {
            if (string.IsNullOrWhiteSpace(textBox.Text)) 
            {
                ShowMessage("Попълни полето", textBox);
                textBox.CausesValidation = true;
            }
            else if (minLength > -1 && maxLength > - 1 && textBox.Text.Length < minLength && textBox.Text.Length > maxLength)
            {
                ShowMessage(customMessage, textBox);
                textBox.CausesValidation = true;
            }
            else
            {
                if (validateMessages.ContainsKey(textBox))
                {
                    textBox.Parent.Controls.Remove(validateMessages[textBox]);
                    validateMessages.Remove(textBox);
                }
                textBox.CausesValidation = false;
            }
        }

        private static void ShowMessage(string message, TextBox textBox)
        {
            Label label = new Label();
            label.Size = new Size(textBox.Width, 40);
            label.Text = message;
            label.Font = new Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = textBox.Location;
            label.Top += textBox.Size.Height + 5;
            label.ForeColor = Color.Red;
            textBox.Parent.Controls.Add(label);
            
            if (!validateMessages.ContainsKey(textBox))
                validateMessages.Add(textBox, label);
            else
                validateMessages[textBox] = label;
        }
    }
}
