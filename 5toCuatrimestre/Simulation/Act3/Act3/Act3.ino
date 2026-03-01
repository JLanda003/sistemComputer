int lGreen = 2,
  lYellow = 3,
  lOrange = 4,
  lRed = 5;

int btn1 = 12, btn2 = 13;

bool state = false;

void setup() {
  pinMode(lGreen, OUTPUT);
  pinMode(lYellow, OUTPUT);
  pinMode(lOrange, OUTPUT);
  pinMode(lRed, OUTPUT);
  pinMode(btn1, INPUT);
  pinMode(btn2, INPUT);
}

void loop() {
  if (!state){
    if(digitalRead(btn1) == HIGH){
      state = true;
      normalLoop();
      state = false;
    }

    if(digitalRead(btn2) == HIGH){
      state = true;
      inverseLoop();
      state = false;
    }
  }
}

void normalLoop(){
  turnOn(lGreen);
  turnOn(lYellow);
  turnOn(lOrange);
  turnOn(lRed);
}

void inverseLoop(){
  turnOn(lRed);
  turnOn(lOrange);
  turnOn(lYellow);
  turnOn(lGreen);
}

void turnOn(int led){
  digitalWrite(led, HIGH);
  delay(1000);
  digitalWrite(led, LOW);
  delay(1000);
}