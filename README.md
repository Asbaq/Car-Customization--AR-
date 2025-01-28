# 📝 Car Customization (AR) Documentation 🚗📱

## 📌 Project Overview  
![Car Customization AR](https://user-images.githubusercontent.com/62818241/211153350-341becc0-b0a7-41aa-b021-c30da03515ff.jpeg)

**Car Customization (AR)** is a Unity-based **Augmented Reality (AR) application** that allows users to customize the color of a 3D car model using an interactive UI. The project is powered by **Vuforia**, enabling real-time AR visualization. Users can rotate the car and change its color dynamically, making it a perfect showcase for AR-based car customization experiences.

---

## 💪 Key Features

✅ **Real-Time Car Customization** with color-changing functionality.  
✅ **Augmented Reality Support** using Vuforia.  
✅ **Smooth Car Rotation** for a 360-degree view.  
✅ **User-Friendly Interface** for intuitive interaction.  
✅ **Optimized Performance** for mobile and AR platforms.  

---

## 🎮 Application Mechanics

### 🎨 Car Color Customization (ColorChanged.cs)
- Users can select different colors to apply to the car.
- Uses **Unity's Renderer component** to modify material properties.
- Supports multiple color options such as **Red, Black, Orange, Green, and Yellow**.

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanged : MonoBehaviour
{
    public Color[] colors;
    public Renderer[] mat;

    public void Red()
    {
        for(int i=0; i<mat.Length; i++)
        {
            mat[i].material.color = colors[0];
        }
    }
    public void Black()
    {
        for(int i=0; i<mat.Length; i++)
        {
            mat[i].material.color = colors[1];
        }
    }
    public void Orange()
    {
        for(int i=0; i<mat.Length; i++)
        {
            mat[i].material.color = colors[2];
        }
    }
    public void Green()
    {
        for(int i=0; i<mat.Length; i++)
        {
            mat[i].material.color = colors[3];
        }
    }
    public void Yellow()
    {
        for(int i=0; i<mat.Length; i++)
        {
            mat[i].material.color = colors[4];
        }
    }
}
```

### 🔄 Car Rotation (Rotate.cs)
- Allows the user to rotate the car model smoothly.
- Uses **Time.deltaTime** for frame-rate-independent movement.

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 rot;

    void Update()
    {
        transform.Rotate(rot * Time.deltaTime);
    }
}
```

---

## 🎤 Implementation Steps

1. **Set up a Unity project** and integrate **Vuforia** for AR functionality.
2. **Import a 3D car model** into the Unity scene.
3. **Attach the ColorChanged.cs script** to allow real-time color customization.
4. **Attach the Rotate.cs script** to enable smooth rotation.
5. **Create UI buttons** for selecting different colors and assign corresponding methods.
6. **Configure AR camera settings** to recognize the target image.
7. **Build and deploy** the AR app on a mobile device for testing.

---

## 🚀 Features & Future Improvements

✅ **Interactive AR Car Customization**  
✅ **Smooth Rotation for 360-degree View**  
✅ **Multiple Color Options**  
✅ **Optimized for Mobile AR**  

🔜 **Real-time Texture Customization**  
🔜 **Different Car Models for Selection**  
🔜 **Enhanced UI & Gesture-Based Controls**  

---

## 📌 Conclusion

**Car Customization (AR)** is an immersive **AR-based vehicle customization experience** that enables users to change car colors and rotate the model in real time. With **Vuforia integration, smooth UI interactions, and optimized performance**, this project serves as a strong foundation for expanding into **texture customization, multiple car models, and advanced AR interactions**. 🚀
