int ledBlue = 2;
int btnPush = 7;

int status;

void setup() {
  pinMode(btnPush, INPUT);
  pinMode(ledBlue, OUTPUT);
}

void loop() {
  status = digitalRead(btnPush);

  if(status == HIGH){
    digitalWrite(ledBlue, status);
  }

  digitalWrite(ledBlue, status);

  delay(1000);
}
