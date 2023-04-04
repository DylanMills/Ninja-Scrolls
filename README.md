# Ninja Scrolls | Graphics Course Project

Shader Demonstration in Ninja Scrolls

## Work Process

- I completed all my shaders using URP and then I got to work on set-dressing. 
- I made the terrain more dynamic rather than just flat,
and I used a modified grass prefab brush to flesh out the organic feel of the map.
- I adjusted the Cel-Shader so that the material is able to cast and receive shadows.

## Integration
- For this Shader Demo, I spent countless hours fine-tuning the colors/shaders to get the most aesthetic scene possible.
- I started with my sample-scene which was essentially empty and was just for gameplay-testing.
- I brought in a "Nuketown" model for the level since it is highly simple, iconic, and versatile in how it can be portrayed.
- I spent hours trying to figure out how to get the desired Toon Shading effect using URP Shader Graphs and following that,
- I began to work on setting win conditions.

## Texturing
- Added Texturing to all main materials
- Steko House Texture via Normal Mapping
![Steko](https://raw.githubusercontent.com/DylanMills/Ninja-Scrolls/main/Screenshots/steko.png)
- Brick house via normal mapping
![Brick](https://raw.githubusercontent.com/DylanMills/Ninja-Scrolls/main/Screenshots/brick.png)
- Rough pavement, sidewalk, and roofing via normal mapping
![Normal](https://raw.githubusercontent.com/DylanMills/Ninja-Scrolls/main/Screenshots/normal.png)




## Visual-Effects
- I added wisps particles floating around the scene.
![Particles](https://raw.githubusercontent.com/DylanMills/Ninja-Scrolls/main/Screenshots/particles.png)
- Chalk decals on pavement
![Decal](https://raw.githubusercontent.com/DylanMills/Ninja-Scrolls/main/Screenshots/decal.png)
- Cel Shading via shadergraphs
![Cel-Shader](https://raw.githubusercontent.com/DylanMills/Ninja-Scrolls/main/Screenshots/cel-shader.png)
- Windows, with highly reflective material
![Cel-Shader](https://raw.githubusercontent.com/DylanMills/Ninja-Scrolls/main/Screenshots/window.png)
- Glowing Grass via additive transparency
![Grass](https://raw.githubusercontent.com/DylanMills/Ninja-Scrolls/main/Screenshots/grass.png)
- Shadows
![Shadows](https://raw.githubusercontent.com/DylanMills/Ninja-Scrolls/main/Screenshots/shadows.png)

## Color-Correction
- When I tried implementing the color-correction using the LUTs and Shaders,
I struggled to find a good way of implementing it into my URP scene.
- I decided to use an alternative method which uses the Volume Component where I could modify all the values in the inspector.
- I decided to implement all of my postprocessing effects using the URP Volume Profiles as it allows for easier adjustment while also being more optimized
- I have three main color profiles, Cool, Warm, and Neon
![No-Post](https://raw.githubusercontent.com/DylanMills/Ninja-Scrolls/main/Screenshots/no-post.png)
![Post](https://raw.githubusercontent.com/DylanMills/Ninja-Scrolls/main/Screenshots/post.png)
![Blue-Post](https://raw.githubusercontent.com/DylanMills/Ninja-Scrolls/main/Screenshots/cool-post.png)
![Red-Post](https://raw.githubusercontent.com/DylanMills/Ninja-Scrolls/main/Screenshots/red-post.png)
![Neon-Post](https://raw.githubusercontent.com/DylanMills/Ninja-Scrolls/main/Screenshots/neon-post.png)
![Night-Post](https://raw.githubusercontent.com/DylanMills/Ninja-Scrolls/main/Screenshots/night-post.png)




## Post-Processing-Effects
- Color Correction
- Bloom
- Depth of Field
- Vignette
- Lens Distortion
- Chromatic Aberration
- Film Grain

## Author

Dylan Mills  | 100750193

## Acknowledgments

Assets
* [Grass Prefab](https://assetstore.unity.com/packages/3d/environments/lowpoly-environment-nature-pack-free-187052)
* [Skybox](https://assetstore.unity.com/packages/2d/textures-materials/sky/fantasy-skybox-free-18353)
* [Base Character Controller](https://assetstore.unity.com/packages/essentials/starter-assets-first-person-character-controller-196525)
* [Bow Animation and Model](https://assetstore.unity.com/packages/tools/animation/standardize-bows-139068)
* [Rim Light Tutorial](https://www.youtube.com/watch?v=jcMRaFF9RRI&ab_channel=NedMakesGames)
* [Toon Shader Tutorial](https://youtu.be/lUmRJRrZfGc)
* [Nuketown Model](https://sketchfab.com/3d-models/nuketown-from-call-of-duty-d692296e16e34d499a6fd7508a0e1b3a)
* [Arrow 3D Model](https://sketchfab.com/3d-models/arrow-3b7c2124180c4b349ca533f0bb4cc955)
* [Glass Shadergraph](https://www.youtube.com/watch?v=V4f8P4hbdkI)
* [Chalk Decal](https://pngtree.com/so/blackboard)

