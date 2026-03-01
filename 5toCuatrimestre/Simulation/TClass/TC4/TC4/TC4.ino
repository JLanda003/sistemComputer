float pot = A0,
  sens;

int lBlue =  2,
  lGreen = 3,
  lYellow = 4,
  lOrange = 5,
  lRed = 6;

int btn1 = 13;

int state = 0, previousState = 0;
bool turnOn = false;

void setup() {
  pinMode(lBlue, OUTPUT);
  pinMode(lGreen, OUTPUT);
  pinMode(lYellow, OUTPUT);
  pinMode(lOrange, OUTPUT);
  pinMode(lRed, OUTPUT);

  pinMode(pot, INPUT);
  pinMode(btn1, INPUT);
}

void loop() {
  sens = analogRead(pot);
  state = digitalRead(btn1);
  /**
  * Lo puertos analogicos de arduino lee valores de 10 Bits que se traduce a tensión electrica con valor de 0 a 5V
  */
  // ledActive();
  
  if(state == HIGH && previousState == LOW){
    turnOn = !turnOn;
    delay(100);
  } else {
    reset();
  }

  previousState = state;

  if(turnOn){
    ledActive();
  }
}

void reset(){
  digitalWrite(lBlue, LOW);
  digitalWrite(lGreen , LOW);
  digitalWrite(lYellow, LOW);
  digitalWrite(lOrange, LOW);
  digitalWrite(lRed, LOW);
};

void ledActive(){
   if(sens >= 0 && sens <= 200) {
    digitalWrite(lBlue, HIGH);
    digitalWrite(lGreen , LOW);
    digitalWrite(lYellow, LOW);
    digitalWrite(lOrange, LOW);
    digitalWrite(lRed, LOW);
  }
  if(sens > 200 && sens <= 400) {
    digitalWrite(lBlue, HIGH);
    digitalWrite(lGreen , HIGH);
    digitalWrite(lYellow, LOW);
    digitalWrite(lOrange, LOW);
    digitalWrite(lRed, LOW);
  }
  if(sens > 400 && sens <= 600) {
    digitalWrite(lBlue, HIGH);
    digitalWrite(lGreen , HIGH);
    digitalWrite(lYellow, HIGH);
    digitalWrite(lOrange, LOW);
    digitalWrite(lRed, LOW);
  }
  if(sens > 600 && sens <= 800) {
    digitalWrite(lBlue, HIGH);
    digitalWrite(lGreen , HIGH);
    digitalWrite(lYellow, HIGH);
    digitalWrite(lOrange, HIGH);
    digitalWrite(lRed, LOW);
  }
  if(sens > 800) {
    digitalWrite(lBlue, HIGH);
    digitalWrite(lGreen , HIGH);
    digitalWrite(lYellow, HIGH);
    digitalWrite(lOrange, HIGH);
    digitalWrite(lRed, HIGH);
  }
}