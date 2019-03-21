# Mapping

Pieza para videomapping realizada en Unity, usando código para configurar y animar una escena. Hace parte de un proyecto donde los estudiantes del curso Entretenimiento Digital, Espacios, Mapping y VJ, realizó cada uno una pieza usando diferentes tecnologías, generalmente solo animación ya fuera en 3D o 2D.

[Ver en YouTube esta pieza realizada en Unity, con sonido añadido](https://youtu.be/gxjTIS4JW4c)

[Ver en YouTube la proyección en videomapping para el proyecto completo](https://www.youtube.com/watch?v=YUdvcDrJ7rc)

![alt text](https://lh5.googleusercontent.com/O1sJpYpmpTTf0r8gml_iuTQRhCFoKSi4l5AIAQzoarvvuIOVZt6cOBB1jhogrWvnumGSezLZN8MSgUeo5HrLODdrVX8KaZVegbPr=w1919-h921)

![alt text](https://lh4.googleusercontent.com/lm1JyXOUGEjX6drYepLfS4BWnfsRW8ajDPh-zOpcxoo67UZ8BCgRJ4lPfheB63VOujESt3tSLVnA1DO4GdW-mF6dOmOTDABquwm7=w1919-h921)

Consta de unos cubos en una rejilla de 8x5, que en una cara tienen un material con la textura global, cada uno toma la parte que le corresponde. Para poderlos identificar, cada cubo sabe cuál es su coordenada en X y coordenada en Y y también tiene un identificador del 1 al 40 asignado. El haberlo separado por coordenadas me ayudó a dividirlo como se ve en la primera imagen, cruzando por ejemplo la X y Y pares, las impares y las que sobran (que incluso podrían dividirse si quisiera en X par y Y impar | X impar y Y par). Y las combinaciones pueden ser más incluso(por ejemplo, solo algunas columnas enteras, o solo algunas filas enteras), pero me quise quedar con esas para lo que se realizó.

Las animaciones todas están hechas vía código haciendo uso del plugin DOTween que me permite hacerlo de forma relativamente sencilla. Entonces lo que hice fue animar con esas divisiones (colores) que había hecho antes, para darle un poco de variabilidad. También puedo cambiar la textura por la que yo quiera de forma fácil, ya sea a toda la rejilla de cubos o a los cubos que yo quiera. Cambiando unos valores en código puedo hacer que incluso tenga el doble de cubos (16x10). Con este sistema puedo hacer transiciones (teniendo el frame final de un clip y el inicial del otro), no muy complejas, pero se puede. Y desde Unity no se demora tanto exportando, porque como Unity hace render en vivo, lo mío que es de 20 sec aprox se demoró como 10 minutos o menos. Y listo, si tiene alguna duda, me cuenta.



