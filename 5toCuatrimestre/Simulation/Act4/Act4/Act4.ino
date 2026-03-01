int lBlue =  2,
  lGreen = 3,
  lYellow = 4,
  lOrange = 5,
  lRed = 6,
  btn = 13,
  pot = A0;

int mode = 0; //0 = turnOff, 1= mode 1, 2 = mode 2

int sens = 0,
  btnState = 0,
  lastBtnState = 0;

unsigned long start1023 = 0;
bool in1023 = false;

void setup() {
  pinMode(lBlue, OUTPUT);
  pinMode(lGreen, OUTPUT);
  pinMode(lYellow, OUTPUT);
  pinMode(lOrange, OUTPUT);
  pinMode(lRed, OUTPUT);

  pinMode(pot, INPUT);
  pinMode(btn, INPUT);
}

void loop() {
  sens = analogRead(pot);
  btnState = digitalRead(btn);

  if(btnState == HIGH && lastBtnState == LOW) {
    mode = (mode % 2) + 1;

    delay(200);
  }
  
  lastBtnState = btnState;

  if(mode == 1)
    firtsMode();

  if(mode == 2)
    secondMode();
}

void turnOn(int pin){
  digitalWrite(pin, HIGH);
  delay(1000);
  digitalWrite(pin, LOW);
  delay(1000);
}

void reset() {
  digitalWrite(lBlue, LOW);
  digitalWrite(lGreen , LOW);
  digitalWrite(lYellow, LOW);
  digitalWrite(lOrange, LOW);
  digitalWrite(lRed, LOW);
};

void warning() {
  turnOn(lRed);
}

void sequence() {
  turnOn(lBlue);
  turnOn(lGreen);
  turnOn(lYellow);
  turnOn(lOrange);
  turnOn(lRed);
}

void reverseSequence() {
  turnOn(lRed);
  turnOn(lOrange);
  turnOn(lYellow);
  turnOn(lGreen);
  turnOn(lBlue);
}

void firtsMode() {
  reset();

  //Validaciones basicas por medida
  if(sens <= 200) {
    digitalWrite(lBlue, HIGH);
  }
  else if(sens <= 400) {
    digitalWrite(lBlue, HIGH);
    digitalWrite(lGreen , HIGH);
  }
  else if(sens <= 600) {
    digitalWrite(lBlue, HIGH);
    digitalWrite(lGreen , HIGH);
    digitalWrite(lYellow, HIGH);
  }
  else if(sens <= 800) {
    digitalWrite(lBlue, HIGH);
    digitalWrite(lGreen , HIGH);
    digitalWrite(lYellow, HIGH);
    digitalWrite(lOrange, HIGH);
  }
  else if(sens <= 1022) {
    digitalWrite(lBlue, HIGH);
    digitalWrite(lGreen , HIGH);
    digitalWrite(lYellow, HIGH);
    digitalWrite(lOrange, HIGH);
    digitalWrite(lRed, HIGH);
  }

  //Validacion para advertencia de 1023
  else if(sens == 1023) {
    if(!in1023) {
      in1023 = true;
      start1023 = millis(); //Inicializamos el contador de los segundos
    }
    
    warning(); // Secuencia de alerta para led rojo

    if(millis() - start1023 >= 5000) {
      reverseSequence();
      reverseSequence();

      reset();
      mode = 0; // Apagamos el sistema
      in1023 = false; //Retornamos el caso a falso
    }
  }

  if(sens != 1023) {
    in1023 = false; //Retornamos el caso a falso
  }
}

void secondMode() {
  reset();

  if(sens == 512) {
    sequence();
    reverseSequence();
  }
}