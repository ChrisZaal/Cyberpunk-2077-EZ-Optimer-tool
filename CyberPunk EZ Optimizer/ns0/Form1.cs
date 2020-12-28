using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ns0
{
	public sealed partial class Form1 : Form
	{
		public Form1()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!Directory.Exists(".\\engine\\config\\platform\\pc"))
			{
				MessageBox.Show("Place the EZ Optimizer into root(main) Cyberpunk 2077 folder!", "Wrong folder!");
			}
			string path = ".\\\\engine\\\\config\\\\platform\\\\pc\\\\user.ini";
			FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
			StreamWriter streamWriter = new StreamWriter(fileStream);
			streamWriter.WriteLine("[Developer/FeatureToggles]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("Antialiasing = True");
			streamWriter.WriteLine("Bloom = True");
			streamWriter.WriteLine("CharacterLightBlockers = False");
			streamWriter.WriteLine("CharacterRimEnhancement = False");
			streamWriter.WriteLine("CharacterSubsurfaceScattering = True");
			streamWriter.WriteLine("ChromaticAberration = True");
			streamWriter.WriteLine("ConstrastAdaptiveSharpening = True");
			streamWriter.WriteLine("ContactShadows = True");
			streamWriter.WriteLine("DepthOfField = True");
			streamWriter.WriteLine("DistantFog = False");
			streamWriter.WriteLine("DistantGI = False");
			streamWriter.WriteLine("DistantShadows = True");
			streamWriter.WriteLine("DistantVolFog = False");
			streamWriter.WriteLine("DynamicDecals = True");
			streamWriter.WriteLine("FilmGrain = True");
			streamWriter.WriteLine("GlobalIllumination = True");
			streamWriter.WriteLine("Hair = True");
			streamWriter.WriteLine("ImageBasedFlares = True");
			streamWriter.WriteLine("LocalShadows = True");
			streamWriter.WriteLine("MotionBlur = False");
			streamWriter.WriteLine("RainMap = True");
			streamWriter.WriteLine("RuntimeTangentUpdate = False");
			streamWriter.WriteLine("ScreenSpaceHeatHaze = False");
			streamWriter.WriteLine("ScreenSpacePlanarReflection = False");
			streamWriter.WriteLine("ScreenSpaceRain = False");
			streamWriter.WriteLine("ScreenSpaceReflection = False");
			streamWriter.WriteLine("ScreenSpaceUnderwater = False");
			streamWriter.WriteLine("SSAO = True");
			streamWriter.WriteLine("VolumetricClouds = False");
			streamWriter.WriteLine("VolumetricFog = False");
			streamWriter.WriteLine("Weather = True");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("[Rendering/AsyncCompute]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("BuildDepthChain = False");
			streamWriter.WriteLine("DynamicTexture = False");
			streamWriter.WriteLine("Enable = False");
			streamWriter.WriteLine("FlattenNormals = False");
			streamWriter.WriteLine("LutGeneration = False");
			streamWriter.WriteLine("RaytraceASBuild = False");
			streamWriter.WriteLine("SSAO = False");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("[Rendering/FrostedGlass]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("GlassUseMipChain = True");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("[Rendering]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("RainMapProxySorting = True");
			streamWriter.WriteLine("UseExperimentalVolFog = False");
			streamWriter.WriteLine("UseSkinningLOD = True");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("[Rendering/Shadows]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("CascadeFitToWorstCase = True");
			streamWriter.WriteLine("CascadeUseBackfacesAsCullingPlanes = True");
			streamWriter.WriteLine("");
			streamWriter.Flush();
			streamWriter.Close();
			fileStream.Close();
			MessageBox.Show("Max Boost profile applied. Enjoy :)", "EZ Optimizer");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (!Directory.Exists(".\\engine\\config\\platform\\pc"))
			{
				MessageBox.Show("Place the EZ Optimizer into root(main) Cyberpunk 2077 folder!", "Wrong folder!");
			}
			string path = ".\\\\engine\\\\config\\\\platform\\\\pc\\\\user.ini";
			FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
			StreamWriter streamWriter = new StreamWriter(fileStream);
			streamWriter.WriteLine("[Developer/FeatureToggles]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("Antialiasing = True");
			streamWriter.WriteLine("Bloom = True");
			streamWriter.WriteLine("CharacterLightBlockers = True");
			streamWriter.WriteLine("CharacterRimEnhancement = True");
			streamWriter.WriteLine("CharacterSubsurfaceScattering = True");
			streamWriter.WriteLine("ChromaticAberration = True");
			streamWriter.WriteLine("ConstrastAdaptiveSharpening = True");
			streamWriter.WriteLine("ContactShadows = True");
			streamWriter.WriteLine("DepthOfField = True");
			streamWriter.WriteLine("DistantFog = True");
			streamWriter.WriteLine("DistantGI = True");
			streamWriter.WriteLine("DistantShadows = True");
			streamWriter.WriteLine("DistantVolFog = True");
			streamWriter.WriteLine("DynamicDecals = True");
			streamWriter.WriteLine("FilmGrain = True");
			streamWriter.WriteLine("GlobalIllumination = True");
			streamWriter.WriteLine("Hair = True");
			streamWriter.WriteLine("ImageBasedFlares = True");
			streamWriter.WriteLine("LocalShadows = True");
			streamWriter.WriteLine("MotionBlur = True");
			streamWriter.WriteLine("RainMap = True");
			streamWriter.WriteLine("RuntimeTangentUpdate = True");
			streamWriter.WriteLine("ScreenSpaceHeatHaze = True");
			streamWriter.WriteLine("ScreenSpacePlanarReflection = True");
			streamWriter.WriteLine("ScreenSpaceRain = True");
			streamWriter.WriteLine("ScreenSpaceReflection = True");
			streamWriter.WriteLine("ScreenSpaceUnderwater = True");
			streamWriter.WriteLine("SSAO = True");
			streamWriter.WriteLine("VolumetricClouds = True");
			streamWriter.WriteLine("VolumetricFog = False");
			streamWriter.WriteLine("Weather = True");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("[Rendering/AsyncCompute]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("BuildDepthChain = False");
			streamWriter.WriteLine("DynamicTexture = False");
			streamWriter.WriteLine("Enable = False");
			streamWriter.WriteLine("FlattenNormals = False");
			streamWriter.WriteLine("LutGeneration = False");
			streamWriter.WriteLine("RaytraceASBuild = False");
			streamWriter.WriteLine("SSAO = False");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("[Rendering/FrostedGlass]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("GlassUseMipChain = True");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("[Rendering]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("RainMapProxySorting = True");
			streamWriter.WriteLine("UseExperimentalVolFog = True");
			streamWriter.WriteLine("UseSkinningLOD = True");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("[Rendering/Shadows]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("CascadeFitToWorstCase = True");
			streamWriter.WriteLine("CascadeUseBackfacesAsCullingPlanes = True");
			streamWriter.WriteLine("");
			streamWriter.Flush();
			streamWriter.Close();
			fileStream.Close();
			MessageBox.Show("Async Compute Disabled", "EZ Optimizer");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (!Directory.Exists(".\\engine\\config\\platform\\pc"))
			{
				MessageBox.Show("Place the EZ Optimizer into root(main) Cyberpunk 2077 folder!", "Wrong folder!");
			}
			string path = ".\\\\engine\\\\config\\\\platform\\\\pc\\\\user.ini";
			FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
			StreamWriter streamWriter = new StreamWriter(fileStream);
			streamWriter.WriteLine("[Developer/FeatureToggles]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("Antialiasing = True");
			streamWriter.WriteLine("Bloom = True");
			streamWriter.WriteLine("CharacterLightBlockers = False");
			streamWriter.WriteLine("CharacterRimEnhancement = False");
			streamWriter.WriteLine("CharacterSubsurfaceScattering = True");
			streamWriter.WriteLine("ChromaticAberration = True");
			streamWriter.WriteLine("ConstrastAdaptiveSharpening = True");
			streamWriter.WriteLine("ContactShadows = True");
			streamWriter.WriteLine("DepthOfField = True");
			streamWriter.WriteLine("DistantFog = False");
			streamWriter.WriteLine("DistantGI = False");
			streamWriter.WriteLine("DistantShadows = True");
			streamWriter.WriteLine("DistantVolFog = False");
			streamWriter.WriteLine("DynamicDecals = True");
			streamWriter.WriteLine("FilmGrain = True");
			streamWriter.WriteLine("GlobalIllumination = True");
			streamWriter.WriteLine("Hair = True");
			streamWriter.WriteLine("ImageBasedFlares = True");
			streamWriter.WriteLine("LocalShadows = True");
			streamWriter.WriteLine("MotionBlur = False");
			streamWriter.WriteLine("RainMap = True");
			streamWriter.WriteLine("RuntimeTangentUpdate = False");
			streamWriter.WriteLine("ScreenSpaceHeatHaze = False");
			streamWriter.WriteLine("ScreenSpacePlanarReflection = False");
			streamWriter.WriteLine("ScreenSpaceRain = False");
			streamWriter.WriteLine("ScreenSpaceReflection = False");
			streamWriter.WriteLine("ScreenSpaceUnderwater = False");
			streamWriter.WriteLine("SSAO = True");
			streamWriter.WriteLine("VolumetricClouds = False");
			streamWriter.WriteLine("VolumetricFog = True");
			streamWriter.WriteLine("Weather = True");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("[Rendering/AsyncCompute]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("BuildDepthChain = False");
			streamWriter.WriteLine("DynamicTexture = False");
			streamWriter.WriteLine("Enable = False");
			streamWriter.WriteLine("FlattenNormals = False");
			streamWriter.WriteLine("LutGeneration = False");
			streamWriter.WriteLine("RaytraceASBuild = False");
			streamWriter.WriteLine("SSAO = False");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("[Rendering/FrostedGlass]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("GlassUseMipChain = True");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("[Rendering]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("RainMapProxySorting = True");
			streamWriter.WriteLine("UseExperimentalVolFog = False");
			streamWriter.WriteLine("UseSkinningLOD = True");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("[Rendering/Shadows]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("CascadeFitToWorstCase = True");
			streamWriter.WriteLine("CascadeUseBackfacesAsCullingPlanes = True");
			streamWriter.WriteLine("");
			streamWriter.Flush();
			streamWriter.Close();
			fileStream.Close();
			MessageBox.Show("Balanced profile applied. Enjoy :)", "EZ Optimizer");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (!Directory.Exists(".\\engine\\config\\platform\\pc"))
			{
				MessageBox.Show("Place the EZ Optimizer into root(main) Cyberpunk 2077 folder!", "Wrong folder!");
			}
			string path = ".\\\\engine\\\\config\\\\platform\\\\pc\\\\user.ini";
			File.Delete(path);
			MessageBox.Show("Stock settiggs applied!", "EZ Optimizer");
		}

		private void button9_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/c/EZPCTECH?sub_confirmation=1");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.paypal.com/pools/c/8mWDayLzDh");
		}

		private void label6_Click(object sender, EventArgs e)
		{
			Process.Start("https://youtu.be/ZfzUoDAEqJY");
		}

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
