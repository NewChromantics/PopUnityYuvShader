using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopX
{
	//	for use with PopYuv shader, these enum values should match the shader
	public enum PixelFormat
	{
		Debug			=999,
		Invalid			=0,
		Greyscale		=1,
		RGB				=2,
		RGBA			=3,
		BGRA			=4,
		BGR				=5,
		YYuv_8888_Full	=6,
		YYuv_8888_Ntsc	=7,
		Depth16mm		=8,
		Chroma_U		=9,
		Chroma_V		=10,
		ChromaUV_88		=11,
		ChromaVU_88		=12,
		Luma_Ntsc		=13,
	}

	public class PopYuv
	{
		public static string[] FormatUniforms = new string[] { "LumaFormat", "ChromaUFormat", "ChromaVFormat" };

		public static void SetMaterialFormats(Material material,List<PixelFormat> Formats)
		{
			for (var i = 0; i < FormatUniforms.Length; i++)
			{
				var Uniform = FormatUniforms[i];
				var Format = (Formats?.Count > i) ? Formats[i] : PixelFormat.Invalid;
				material.SetInt(Uniform, (int)Format);
			}
		}
	}
}
