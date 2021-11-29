# Parallax Poster

A shader that renders a multi-layered parallax effect suitable for posters.

## Installation

Download the repository. Then place the Shader/ folder with the shader into your Assets/ directory.

## Usage

This shader provides 6 layers, plus a background layer. The Parallax Scale sets the overall depth of the poster.

The Normal Map has two uses. 
It can act like thick glass and warp the parallax layers behind it. This is controlled by Warp Scale. 
It can change the lighting of the surface. This is controlled by Normal Scale. Note that Normal Scale mainly affects reflections and diffuse light.

The background layer, layer 0, has special properties. It has a fresnel mask that darkens it when viewed at glancing angles, and blurs the edges, giving it an unfocused appearance. 

The MOES map controls the metallic, occlusion, emission, and smoothness parameters.

The performance settings disable layers. You can use this to have a 1, 3, or 4 layer parallax instead. If using this shader on mobile platforms, it's recommended to use fewer layers.

## License?
This shader is licensed under MIT license.
Image assets are licensed under CC-4.0-BY-NC-SA.
