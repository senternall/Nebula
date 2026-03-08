shader_type canvas_item;

uniform vec3 outline_color : source_color = vec3(0.05, 0.0, 0.05);
uniform float outline_opacity : hint_range(0.0, 1.0) = 1.0;
uniform vec4 light_color : source_color = vec4(0.79, 0.0, 0.79, 1.0);
uniform vec4 cursor_light_color : source_color = vec4(0.15, 0.0, 0.15, 1.0);
uniform float fill : hint_range(0.0, 1.0) = 0.0;
uniform float glow_radius : hint_range(0.0, 1000.0, 1.0) = 350.0;
uniform float glow_exponent : hint_range(0.0, 10.0, 0.1) = 2.0;
uniform vec2 light_position = vec2(0.0);
uniform vec2 cursor_position = vec2(0.0);

void fragment() {
	float cursor_glow = glow_radius - distance(cursor_position, FRAGCOORD.xy);
	vec4 color = mix(vec4(outline_color, 1.0), vec4(cursor_light_color), cursor_light_color.a * clamp(cursor_glow / glow_radius, 0.0, 1.0));

	float fill_glow = 1.0 - UV.x + 2.0 * (fill - 0.5);
	color = mix(color, light_color, clamp(fill_glow, 0.0, 1.0));

	float selection_glow = glow_radius - distance(light_position, FRAGCOORD.xy);
	color = mix(color, light_color, pow(clamp(selection_glow / glow_radius, 0.0, 1.0), glow_exponent));

	COLOR = vec4(color.rgb, COLOR.a * outline_opacity);
}