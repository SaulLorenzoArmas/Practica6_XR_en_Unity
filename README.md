# Practica6_XR_en_Unity

En esta práctica se configura un entorno de realidad virtual en Unity utilizando el paquete `XR Interaction Toolkit` (OpenXR). El objetivo es establecer una escena para probar el agarre e interacción física con distintos objetos utilizando mandos virtuales.

## Ejercicio 1: Interacción a distancia y cambio de material

Se han configurado objetos básicos empleando los componentes `Rigidbody` y `XR Grab Interactable`. Para lograr el cambio al seleccionarlos, se ha modificado el material mediante las opciones predeterminadas del motor, asignando el componente `MeshRenderer` a los eventos `Select Entered`.

## Ejercicio 2: Interacción directa y actualización de UI

Se ha establecido una capa llamada `SoloMano` en el `Interaction Layer Mask` para limitar el agarre al contacto directo mediante el `Near-Far Interactor`, desactivando el puntero láser para este elemento. Además, se ha integrado un evento personalizado asociado al evento de selección del objeto, el cual ejecuta la función  `ActualizarTexto()` para modificar una interfaz de usuario
 en tiempo real al agarrar el objeto.
