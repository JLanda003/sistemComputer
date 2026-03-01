int lGreen = 3,
  lYellow = 4,
  lOrange = 5,
  lRed = 6;

int btn1 = 12, btn2 = 13;

int value2;

int previousState = 0, state;

int startLoop, invLoop = 0;

void setup() {
  pinMode(lGreen, OUTPUT);
  pinMode(lYellow, OUTPUT);
  pinMode(lOrange, OUTPUT);
  pinMode(lRed, OUTPUT);
  pinMode(btn1, OUTPUT);
  pinMode(btn2, OUTPUT);
}

void loop() {
  value2 = digitalRead(btn2);

  state = digitalRead(btn1);

  if(state == HIGH && previousState == LOW){
    startLoop = 1 - startLoop;
    delay(100);
  }

  previousState = state;

  if(startLoop == 1 && invLoop == 0 && !digitalRead(lYellow)){
    invLoop = 1;
    digitalWrite(lGreen, HIGH);
    delay(500);
    digitalWrite(lGreen, LOW);
    digitalWrite(lYellow, HIGH);
  }

  if(value2 == HIGH && startLoop == 1 && invLoop == 1 && !digitalRead(lRed)){
    digitalWrite(lOrange, HIGH);
    delay(500);
    digitalWrite(lOrange, LOW);
    digitalWrite(lRed, HIGH);
  }

  if (state == HIGH && value2 == HIGH){
    startLoop = 0;
    invLoop = 0;
    previousState = 0;
    state = 0;
    value2 = 0;
    digitalWrite(lYellow, LOW);
    digitalWrite(lRed, LOW);
    delay(1000);
  }

}
