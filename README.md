# Gimnasio Siglo — Sistema de Inscripción de Socios 🏋️‍♂️

Aplicación de escritorio desarrollada en **C# (Windows Forms)** como parte del plan de estudios de *Laboratorio de Programación I* (Prácticas SP2 y SP3). 

El sistema permite gestionar la inscripción de nuevos socios a un gimnasio, calculando de manera automática el costo mensual y total en base a diversas reglas de negocio como planes, turnos, promociones por edad, condición de estudiante y facilidades de pago.

---

## 🚀 Características Principales

- **Gestión de Planes y Servicios:** Cálculo de costos de planes principales (*Musculación, Funcional, Natación*) y opcionales adicionales (*Casillero*).
- **Validaciones y Control de Entrada:**
  - Filtrado de caracteres en campos numéricos (Edad y Meses solo admiten dígitos y borrar).
  - Conversión automática a mayúsculas en la carga del nombre.
  - Validación de rango de edad mínima (14 años) y meses de suscripción (1 a 12 meses).
  - Estado del botón de cálculo condicionado a la carga completa de datos obligatorios.
- **Lógica de Descuentos y Recargos:**
  - Descuentos no acumulables por edad o categoría (Menores de 18 años, Senior +65 y Estudiantes).
  - Opciones de pago: Descuento por pago en Efectivo o recargo según cuotas con Tarjeta (1, 3 o 6 cuotas).
- **Estructura Interna:** Empleo de `struct` personalizado (`SOCIO`) para agrupar las propiedades del socio y facilitar la escalabilidad del sistema.

---

## 🛠️ Tecnologías y Conceptos Aplicados

- **Lenguaje / Framework:** C# · .NET Framework · Windows Forms.
- **Estructuras de Control:**
  - `switch` (usado para selección de plan y definición de turno).
  - `if` / `if-else` / `if anidado` / `if` de una línea (validaciones y cálculo de promociones).
  - **Operador Ternario (`?:`)** para asignaciones condicionales rápidas (Categoría del socio, detalle de pago, valor de cuota).
- **Tipos de Datos y Estructuras:** Uso estricto de `decimal` para valores monetarios, constantes globales, y `struct` para empaquetado de datos.
- **Eventos:** Manejo de `KeyPress`, `TextChanged`, `CheckedChanged`, `Click` y `Load`.

---

## 📋 Casos de Prueba Incluidos

El proyecto cuenta con verificación basada en la siguiente matriz de casos de prueba:

| Socio | Edad | Plan | Meses | Casillero | Estudiante | Pago | Subtotal | Total Esperado |
| :--- | :---: | :--- | :---: | :---: | :---: | :--- | :---: | :---: |
| **Ana** | 16 | Musculación | 3 | No | No | Efectivo | $45.000 | **$30.375** |
| **Bruno** | 22 | Funcional | 2 | Sí | Sí | Tarjeta (3c) | $42.000 | **$39.270** |
| **Carla** | 70 | Natación | 1 | Sí | No | Tarjeta (6c) | $25.000 | **$21.000** |
| **Diego** | 30 | Musculación | 12 | No | No | Tarjeta (1c) | $180.000 | **$180.000** |

---

## 🖥️ Requisitos e Instalación

1. **Entorno:** Tener instalado **Visual Studio 2019 / 2022** con la carga de trabajo de *.NET desktop development*.
2. **Clonar repositorio:**
   ```bash
   git clone https://github.com/M4t30A/pryAmayaGimnasio.git
   ```
3. **Ejecutar:**
   - Abrir la solución `.sln` en Visual Studio.
   - Presionar `F5` para compilar y ejecutar la aplicación.
