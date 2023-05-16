using System.Runtime.CompilerServices;

namespace UniSystem
{
    public static class Validator
    {
        private static Dictionary<string, Label> validateMessages = new Dictionary<string, Label>();
        
       public static bool Validate(this TextBox textBox, int minLength = -1, int maxLength = -1, string customMessage = "")
        {
            if (string.IsNullOrWhiteSpace(textBox.Text)) 
            {
                ShowMessage("Попълни полето", textBox);
                return false;
            }
            else if (minLength > -1 && maxLength > - 1 && textBox.Text.Length < minLength && textBox.Text.Length > maxLength)
            {
                ShowMessage(customMessage, textBox);
                return false;
            }
            RemoveMessage(textBox);
            return true;
        }

        private static void RemoveMessage(TextBox textBox)
        {
            if (validateMessages.ContainsKey(textBox.Name))
            {
                validateMessages[textBox.Name].Visible = false;
                validateMessages.Remove(textBox.Name);
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
            
            if (!validateMessages.ContainsKey(textBox.Name))
                validateMessages.Add(textBox.Name, label);
        }
    }
}
