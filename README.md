# Practica6_XR_en_Unity

En esta práctica se configura un entorno de realidad virtual en Unity utilizando el paquete `XR Interaction Toolkit` (OpenXR). El objetivo es crear una escena para probar el agarre e interacción física con distintos objetos utilizando mandos virtuales.

## Ejercicio 1: Interacción a distancia y cambio de material

Se han configurado objetos básicos empleando los componentes `Rigidbody` y `XR Grab Interactable`. Para conseguir el cambio al seleccionarlos, se ha modificado el material mediante las funciones ya existentes, asignando el componente `MeshRenderer` a los eventos `Select Entered`.

![alt text](Imagenes/Ejercicio1.gif)


## Ejercicio 2: Interacción directa y actualización de UI

Se ha establecido una capa llamada `SoloMano` en el `Interaction Layer Mask` para limitar el agarre al contacto directo mediante el `Near-Far Interactor`, desactivando el puntero láser en la mano derecha para este elemento. Además, se ha creado un evento personalizado asociado a la selección del objeto, el cual ejecuta la función  `ActualizarTexto()` para modificar una interfaz de usuario al agarrar el objeto.

![alt text](Imagenes/Ejercicio2.gif)
