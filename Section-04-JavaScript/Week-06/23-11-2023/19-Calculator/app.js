const display = document.querySelector(".calculator-input");
// const keys = document.querySelectorAll("calculator-keys button"); ya da ağaıdaki gibi;

const keys = document.querySelector(".calculator-keys");

let displayValue = "0";
let waitingForSecondValue = false;
let previousValue = null;
let operator = null;

function updateDisplay() {
    display.value = displayValue;
}

//tek tek her butona cick atamak yerine keyse atadık ve eventtarget ile ilgili buto nu yakalamaya çalıştık
keys.addEventListener("click", function (e) {
    const element = e.target;
    const value = element.value;
    if (!element.matches("button")) return; //return burada if i bitiriyor.
    switch (value) {
        case "+":
        case "-":
        case "*":
        case "/":
        case "=":
            handleOperator(value);
            break;
        case ".":
            inputDecimal();
            break;
        case "clear":
            clearDisplay();
            break;
        default:
            inputNumber(value);
            break;
    }
    updateDisplay();
});
function handleOperator(nextOperator) {
    let value = parseFloat(displayValue);
    if (operator != null && waitingForSecondValue == true) {
        operator = nextOperator;
        return;
    }
    if (previousValue == null) {
        previousValue = value;
    } else {
        //eşitire basınca
        const result = calculate(previousValue, operator, value);
        displayValue = result.toString();
        previousValue = result;

    }
    operator = nextOperator;
  
    waitingForSecondValue = true;

}

function calculate(firstNumber, op, secondNumber) {

    switch (op) {
        case "+":
            return firstNumber + secondNumber;
        case "-":
            return firstNumber - secondNumber;
        case "*":
            return firstNumber * secondNumber;
        case "/":
            if (secondNumber == 0) return "Sıfıra bölünemez"
         else   return firstNumber / secondNumber;

        default:
            return secondNumber;

    }
}
function inputDecimal() {
    if (displayValue.indexOf(".") == -1) displayValue += ".";
}

function clearDisplay() {
    displayValue = 0;
    waitingForSecondValue = false;
    previousValue = null;
    operator = null;
}

//ikinci sayıyı girince ekran temizlensin.
function inputNumber(num) {
    if (!waitingForSecondValue) {
        displayValue = displayValue == "0" ? num : displayValue + num;

    } else {
        displayValue = num;
        waitingForSecondValue = false;
    }

}
updateDisplay();
