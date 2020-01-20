﻿#version 330

in vec3 normal;
in vec2 texcoord0;

out vec4 fragColor;

uniform sampler2D tex0;

void main()
{
	vec3 colr = vec3(0.2 + abs(dot(normal, vec3(0, 0, 1))));
	fragColor = texture2D(tex0, texcoord0) * vec4(colr, 1);
}