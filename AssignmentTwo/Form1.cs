////////////////////////////////////////////////////////////////////////////////////////////////////////
//Project: AssignmentTwo - PROG32356
//Authors : Patrick Ryan, James Hong, Muhammad Nasir, Karam Fasih
//Created On : 2020-06-16
//Description : Windows-style Calculator Project
////////////////////////////////////////////////////////////////////////////////////////////////////////

using AssignmentTwo.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentTwo {
    public partial class Form1 : Form {
        Double Result = 0;
        String Operation = String.Empty;
        Double Operand1, Operand2;
        Double StoredValue = 0;
        bool ErrorState = false;
        bool OperationCompleted = false;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        /**
         * Allow limited keyboard input for numbers, decimals, and basic arithmetic.
         */
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.NumPad0 || keyData == Keys.D0)
                btn0.PerformClick();
            if (keyData == Keys.NumPad1 || keyData == Keys.D1)
                btn1.PerformClick();
            if (keyData == Keys.NumPad2 || keyData == Keys.D2)
                btn2.PerformClick();
            if (keyData == Keys.NumPad3 || keyData == Keys.D3)
                btn3.PerformClick();
            if (keyData == Keys.NumPad4 || keyData == Keys.D4)
                btn4.PerformClick();
            if (keyData == Keys.NumPad5 || keyData == Keys.D5)
                btn5.PerformClick();
            if (keyData == Keys.NumPad6 || keyData == Keys.D6)
                btn6.PerformClick();
            if (keyData == Keys.NumPad7 || keyData == Keys.D7)
                btn7.PerformClick();
            if (keyData == Keys.NumPad8 || keyData == Keys.D8)
                btn8.PerformClick();
            if (keyData == Keys.NumPad9 || keyData == Keys.D9)
                btn9.PerformClick();
            if (keyData == Keys.Escape)
                btnClear.PerformClick();
            if (keyData == Keys.Subtract || keyData == Keys.OemMinus)
                btnMinus.PerformClick();
            if (keyData == Keys.Add || keyData == Keys.Oemplus)
                btnAdd.PerformClick();
            if (keyData == Keys.Multiply)
                btnMultiply.PerformClick();
            if (keyData == Keys.Divide)
                btnDivide.PerformClick();
            if (keyData == Keys.Enter)
                btnEqual.PerformClick();
            if (keyData == Keys.Decimal || keyData == Keys.OemPeriod)
                btnDecimal.PerformClick();
            if (keyData == Keys.Back || keyData == Keys.Delete)
                btnBksp.PerformClick();
    
            return base.ProcessCmdKey(ref msg, keyData);
        }

        /**
         * Handle user input from the calculator screen. Perform resets on error state, or if the current
         * operand is zero (i.e., overwrite 0 with 5 when the user presses '5'). Ensures that only one decimal
         * can be added to an operand.
         */
        private void Numbers_Only(object sender, EventArgs e) {
            Button numBtn = (Button)sender;
            if ((txtResult.Text == "0") || ErrorState || OperationCompleted) {
                OperationCompleted = false;
                txtResult.Text = numBtn.Text;
                ErrorState = false;
            } else if (numBtn.Text == ".") {
                if (!txtResult.Text.Contains(".")) {
                    txtResult.Text += numBtn.Text;
                } 
            } else if (OperationCompleted) {
                // Overwrite existing result after calculation complete.
                txtResult.Text = String.Empty;
                OperationCompleted = false;
                txtResult.Text += numBtn.Text;
            } else
            {
                txtResult.Text += numBtn.Text;
            }
            // Removes focus on button after click.
            hiddenLabel.Focus();
        }

        /**
         * Event handler for when users click an operation button.
         */
        private void OperatorBtn_Click(object sender, EventArgs e) {


            // Clicking any operator in the error state is nilpotent.
            if (ErrorState)
            {
                return;
            }

            // Save operand if we did not already have an operation selected. Otherwise, just replace
            // the operation.
            if (String.IsNullOrEmpty(Operation))
            {
                Operand1 = Double.Parse(txtResult.Text);
            }

            Button opBtn = (Button)sender;
            Operation = opBtn.Text;
            
            // Display either the binary or unary operation
            if (IsUnaryOperation(Operation)) 
            {
                showOpLabel.Text = Operation;
            } 
            else 
            {
                txtResult.Text = "0";
                showOpLabel.Text = Operand1 + " " + Operation;
            }

            // Removes focus on button after click
            hiddenLabel.Focus();
        }

        /**
         * Dispatch to operation-specific handlers. Executes the current operation and updates the result.
         */
        private void HandleOperation() {
            if (IsUnaryOperation(Operation))
            {
                HandleUnaryOperation();
            } 
            else
            {
                HandleBinaryOperation();
            }
        }

        /**
         * Execute a binary operation and update the state of the calculator.
         */
        private void HandleBinaryOperation()
        {
            IBinaryOperation Op;
            switch (Operation)
            {
                case "+":
                    Op = new AdditionOperation();
                    break;
                case "-":
                    Op = new SubtractionOperation();
                    break;
                case "*":
                    Op = new MultiplicaitonOperation();
                    break;
                case "÷":
                    Op = new DivisionOperation();
                    break;
                case "MOD":
                    Op = new ModulusOperation();
                    break;
                case "n^x":
                    Op = new PowerOperation();
                    break;
                default:
                    throw new ArithmeticException("Invalid operator " + Operation);
            }
            Result = Op.Compute(Operand1, Operand2);
        }

        /**
         * Execute a unary operation and update the state of the calculator.
         * 
         */
        private void HandleUnaryOperation()
        {
            IUnaryOperation Op;
            switch (Operation)
           {
                case "ln":
                    Op = new NaturalLogarithmOperation();
                    break;
                case "log":
                    Op = new LogarithmOperation();
                    break;
                case "√":
                    Op = new SquareRootOperation();
                    break;
                case "1/x":
                    Op = new ReciprocalOperation();
                    break;
                case "exp":
                    Op = new ExponentOperation();
                    break;
                case "n!":
                    Op = new FactorialOperation();
                    break;
                case "|n|":
                    Op = new AbsoluteOperation();
                    break;
                default:
                    throw new ArithmeticException("Unknown operation encountered");
            }
            Result = Op.Compute(Operand1);
        }

        private void BtnEqual_Click(object sender, EventArgs e) {
            // Pressing the equals button when there is no operation selected is nilpotent,
            // as is pressing equals in the error state
            if (String.IsNullOrEmpty(Operation) || ErrorState)
            {
                return;
            }

            Operand2 = Double.Parse(txtResult.Text);

            // Clear out the intermediate operation display
            showOpLabel.ResetText();

            try { 
                HandleOperation();
                AddHistoryEntry();
                Operation = String.Empty;

                txtResult.Text = Result.ToString();
            }
            catch (ArithmeticException) { 
                txtResult.Text = "Error";
                ErrorState = true;
                ClearOperation();
            }
            OperationCompleted = true;
            // Removes focus on button after click
            hiddenLabel.Focus();
        }

        private void BtnClear_Click(object sender, EventArgs e) {
            txtHistory.ResetText();
            txtResult.ResetText();
            showOpLabel.ResetText();
            txtResult.Text = "0";
            ErrorState = false;
            ClearOperation();

            // Removes focus on button after click
            hiddenLabel.Focus();
        }

        private void TxtHistory_Click(object sender, EventArgs e) {
        }

        /**
         * Perform memory operations for the calculator
         */
        private void BtnMem_Click(object sender, EventArgs e) {
            Button memBtn = (Button)sender;

            if (memBtn.Text == "M+")
            {
                // Attepting to save to memory in the error state is nilpotent.
                if (ErrorState)
                {
                    return;
                }

                StoredValue = Double.Parse(txtResult.Text);
            }
            else if (memBtn.Text == "MR")
            {
                txtResult.Text = Convert.ToString(StoredValue);
            }
            else if (memBtn.Text == "MC")
            {
                StoredValue = 0;
            }

            // Removes focus on button after click
            hiddenLabel.Focus();
        }

        private void BackSpaceBtn_Click(object sender, EventArgs e) {
            // Using backspace in the error state is nilpotent
            if (ErrorState)
            {
                return;
            }

            if (txtResult.Text.Length > 0) 
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }
            if (txtResult.Text == String.Empty) 
            {
                txtResult.Text = "0";
            }

            // Removes focus on button after click
            hiddenLabel.Focus();
        }

        /**
         * Returns true if the provided text matches the text found on the unary operation buttons,
         * false otherwise.
         */
        private bool IsUnaryOperation(String operation)
        {
            String[] unaryOperations = { "ln", "log", "1/x", "exp", "n!", "|n|", "√" };
            return unaryOperations.Contains(operation);
        }

        /**
         * Clear all stored operations, results, and operands
         */
        private void ClearOperation()
        {
            Result = 0;
            Operand1 = 0;
            Operand2 = 0;
            Operation = String.Empty;
        }

        /**
         * Add the most recently completed operation to the history view.
         */
        private void AddHistoryEntry()
        {
            if (IsUnaryOperation(Operation))
            {
                txtHistory.AppendText(Operation + " " + Operand1 + "  =  " + Result + "\n");
            }
            else
            {
                txtHistory.AppendText(Operand1 + " " + Operation + " " + Operand2 + "  =  " + Result + "\n");
            }
        }
    }
}
