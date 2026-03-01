Sensor de temp. LM 35

Me entrega 10 mV/°C ósea 0.01v por °C

Estandarización la señal de 0°C a 100°C



Pero el microcontrolador solo puede operar de forma correcta

en valores de 0 a 5 volts en su entrada analógica. Pero el sensor

nos entregaría de 0 a 1 volt por lo que se requiere incrementar la

señal de salida del sensor, y para esto requerimos utilizar un OPAM

(Amplificador operacional), el cual permite aumentar a 5 V,

usando su configuración **no inversor**.

