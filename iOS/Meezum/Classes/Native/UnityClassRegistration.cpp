template <typename T> void RegisterClass();
template <typename T> void RegisterStrippedTypeInfo(int, const char*, const char*);

void InvokeRegisterStaticallyLinkedModuleClasses()
{
	// Do nothing (we're in stripping mode)
}

void RegisterStaticallyLinkedModulesGranular()
{
	void RegisterModule_Animation();
	RegisterModule_Animation();

	void RegisterModule_Audio();
	RegisterModule_Audio();

	void RegisterModule_CloudWebServices();
	RegisterModule_CloudWebServices();

	void RegisterModule_Physics2D();
	RegisterModule_Physics2D();

	void RegisterModule_TextRendering();
	RegisterModule_TextRendering();

	void RegisterModule_UI();
	RegisterModule_UI();

	void RegisterModule_UnityConnect();
	RegisterModule_UnityConnect();

	void RegisterModule_IMGUI();
	RegisterModule_IMGUI();

	void RegisterModule_UnityWebRequest();
	RegisterModule_UnityWebRequest();

	void RegisterModule_JSONSerialize();
	RegisterModule_JSONSerialize();

}

class EditorExtension; template <> void RegisterClass<EditorExtension>();
namespace Unity { class Component; } template <> void RegisterClass<Unity::Component>();
class Behaviour; template <> void RegisterClass<Behaviour>();
class Animation; 
class Animator; template <> void RegisterClass<Animator>();
class AudioBehaviour; template <> void RegisterClass<AudioBehaviour>();
class AudioListener; template <> void RegisterClass<AudioListener>();
class AudioSource; template <> void RegisterClass<AudioSource>();
class AudioFilter; 
class AudioChorusFilter; 
class AudioDistortionFilter; 
class AudioEchoFilter; 
class AudioHighPassFilter; 
class AudioLowPassFilter; 
class AudioReverbFilter; 
class AudioReverbZone; 
class Camera; template <> void RegisterClass<Camera>();
namespace UI { class Canvas; } template <> void RegisterClass<UI::Canvas>();
namespace UI { class CanvasGroup; } template <> void RegisterClass<UI::CanvasGroup>();
namespace Unity { class Cloth; } 
class Collider2D; template <> void RegisterClass<Collider2D>();
class BoxCollider2D; template <> void RegisterClass<BoxCollider2D>();
class CapsuleCollider2D; template <> void RegisterClass<CapsuleCollider2D>();
class CircleCollider2D; template <> void RegisterClass<CircleCollider2D>();
class CompositeCollider2D; 
class EdgeCollider2D; 
class PolygonCollider2D; 
class ConstantForce; 
class Effector2D; 
class AreaEffector2D; 
class BuoyancyEffector2D; 
class PlatformEffector2D; 
class PointEffector2D; 
class SurfaceEffector2D; 
class FlareLayer; template <> void RegisterClass<FlareLayer>();
class GUIElement; 
namespace TextRenderingPrivate { class GUIText; } 
class GUITexture; 
class GUILayer; template <> void RegisterClass<GUILayer>();
class Halo; 
class HaloLayer; 
class Joint2D; 
class AnchoredJoint2D; 
class DistanceJoint2D; 
class FixedJoint2D; 
class FrictionJoint2D; 
class HingeJoint2D; 
class SliderJoint2D; 
class SpringJoint2D; 
class WheelJoint2D; 
class RelativeJoint2D; 
class TargetJoint2D; 
class LensFlare; 
class Light; 
class LightProbeGroup; 
class LightProbeProxyVolume; 
class MonoBehaviour; template <> void RegisterClass<MonoBehaviour>();
class NavMeshAgent; 
class NavMeshObstacle; 
class NetworkView; template <> void RegisterClass<NetworkView>();
class OffMeshLink; 
class PhysicsUpdateBehaviour2D; 
class ConstantForce2D; 
class Projector; 
class ReflectionProbe; 
class Skybox; 
class SortingGroup; 
class Terrain; 
class VideoPlayer; 
class WindZone; 
namespace UI { class CanvasRenderer; } template <> void RegisterClass<UI::CanvasRenderer>();
class Collider; 
class BoxCollider; 
class CapsuleCollider; 
class CharacterController; 
class MeshCollider; 
class SphereCollider; 
class TerrainCollider; 
class WheelCollider; 
namespace Unity { class Joint; } 
namespace Unity { class CharacterJoint; } 
namespace Unity { class ConfigurableJoint; } 
namespace Unity { class FixedJoint; } 
namespace Unity { class HingeJoint; } 
namespace Unity { class SpringJoint; } 
class LODGroup; 
class MeshFilter; template <> void RegisterClass<MeshFilter>();
class OcclusionArea; 
class OcclusionPortal; 
class ParticleAnimator; 
class ParticleEmitter; 
class EllipsoidParticleEmitter; 
class MeshParticleEmitter; 
class ParticleSystem; 
class Renderer; template <> void RegisterClass<Renderer>();
class BillboardRenderer; 
class LineRenderer; 
class MeshRenderer; template <> void RegisterClass<MeshRenderer>();
class ParticleRenderer; 
class ParticleSystemRenderer; 
class SkinnedMeshRenderer; 
class SpriteRenderer; template <> void RegisterClass<SpriteRenderer>();
class TrailRenderer; 
class Rigidbody; 
class Rigidbody2D; 
namespace TextRenderingPrivate { class TextMesh; } 
class Transform; template <> void RegisterClass<Transform>();
namespace UI { class RectTransform; } template <> void RegisterClass<UI::RectTransform>();
class Tree; 
class WorldAnchor; 
class WorldParticleCollider; 
class GameObject; template <> void RegisterClass<GameObject>();
class NamedObject; template <> void RegisterClass<NamedObject>();
class AssetBundle; 
class AssetBundleManifest; 
class AudioMixer; 
class AudioMixerController; 
class AudioMixerGroup; 
class AudioMixerGroupController; 
class AudioMixerSnapshot; 
class AudioMixerSnapshotController; 
class Avatar; 
class AvatarMask; 
class BillboardAsset; 
class ComputeShader; 
class Flare; 
namespace TextRendering { class Font; } template <> void RegisterClass<TextRendering::Font>();
class LightProbes; 
class Material; template <> void RegisterClass<Material>();
class ProceduralMaterial; 
class Mesh; template <> void RegisterClass<Mesh>();
class Motion; template <> void RegisterClass<Motion>();
class AnimationClip; template <> void RegisterClass<AnimationClip>();
class PreviewAnimationClip; 
class NavMeshData; 
class OcclusionCullingData; 
class PhysicMaterial; 
class PhysicsMaterial2D; 
class PreloadData; template <> void RegisterClass<PreloadData>();
class RuntimeAnimatorController; template <> void RegisterClass<RuntimeAnimatorController>();
class AnimatorController; template <> void RegisterClass<AnimatorController>();
class AnimatorOverrideController; 
class SampleClip; template <> void RegisterClass<SampleClip>();
class AudioClip; template <> void RegisterClass<AudioClip>();
class Shader; template <> void RegisterClass<Shader>();
class ShaderVariantCollection; 
class SpeedTreeWindAsset; 
class Sprite; template <> void RegisterClass<Sprite>();
class SubstanceArchive; 
class TerrainData; 
class TextAsset; template <> void RegisterClass<TextAsset>();
class CGProgram; 
class MonoScript; template <> void RegisterClass<MonoScript>();
class Texture; template <> void RegisterClass<Texture>();
class BaseVideoTexture; 
class MovieTexture; 
class WebCamTexture; 
class CubemapArray; 
class LowerResBlitTexture; template <> void RegisterClass<LowerResBlitTexture>();
class ProceduralTexture; 
class RenderTexture; template <> void RegisterClass<RenderTexture>();
class CustomRenderTexture; 
class SparseTexture; 
class Texture2D; template <> void RegisterClass<Texture2D>();
class Cubemap; template <> void RegisterClass<Cubemap>();
class Texture2DArray; template <> void RegisterClass<Texture2DArray>();
class Texture3D; template <> void RegisterClass<Texture3D>();
class VideoClip; 
class GameManager; template <> void RegisterClass<GameManager>();
class GlobalGameManager; template <> void RegisterClass<GlobalGameManager>();
class AudioManager; template <> void RegisterClass<AudioManager>();
class BuildSettings; template <> void RegisterClass<BuildSettings>();
class CloudWebServicesManager; template <> void RegisterClass<CloudWebServicesManager>();
class CrashReportManager; 
class DelayedCallManager; template <> void RegisterClass<DelayedCallManager>();
class GraphicsSettings; template <> void RegisterClass<GraphicsSettings>();
class InputManager; template <> void RegisterClass<InputManager>();
class MasterServerInterface; template <> void RegisterClass<MasterServerInterface>();
class MonoManager; template <> void RegisterClass<MonoManager>();
class NavMeshProjectSettings; 
class NetworkManager; template <> void RegisterClass<NetworkManager>();
class PerformanceReportingManager; 
class Physics2DSettings; template <> void RegisterClass<Physics2DSettings>();
class PhysicsManager; 
class PlayerSettings; template <> void RegisterClass<PlayerSettings>();
class QualitySettings; template <> void RegisterClass<QualitySettings>();
class ResourceManager; template <> void RegisterClass<ResourceManager>();
class RuntimeInitializeOnLoadManager; template <> void RegisterClass<RuntimeInitializeOnLoadManager>();
class ScriptMapper; template <> void RegisterClass<ScriptMapper>();
class TagManager; template <> void RegisterClass<TagManager>();
class TimeManager; template <> void RegisterClass<TimeManager>();
class UnityAdsManager; 
class UnityAnalyticsManager; 
class UnityConnectSettings; template <> void RegisterClass<UnityConnectSettings>();
class LevelGameManager; template <> void RegisterClass<LevelGameManager>();
class LightmapSettings; template <> void RegisterClass<LightmapSettings>();
class NavMeshSettings; 
class OcclusionCullingSettings; 
class RenderSettings; template <> void RegisterClass<RenderSettings>();
class NScreenBridge; 

void RegisterAllClasses()
{
void RegisterBuiltinTypes();
RegisterBuiltinTypes();
	//Total: 71 non stripped classes
	//0. Behaviour
	RegisterClass<Behaviour>();
	//1. Unity::Component
	RegisterClass<Unity::Component>();
	//2. EditorExtension
	RegisterClass<EditorExtension>();
	//3. Camera
	RegisterClass<Camera>();
	//4. GameObject
	RegisterClass<GameObject>();
	//5. Renderer
	RegisterClass<Renderer>();
	//6. GUILayer
	RegisterClass<GUILayer>();
	//7. Mesh
	RegisterClass<Mesh>();
	//8. NamedObject
	RegisterClass<NamedObject>();
	//9. MonoBehaviour
	RegisterClass<MonoBehaviour>();
	//10. NetworkView
	RegisterClass<NetworkView>();
	//11. Shader
	RegisterClass<Shader>();
	//12. Material
	RegisterClass<Material>();
	//13. Sprite
	RegisterClass<Sprite>();
	//14. SpriteRenderer
	RegisterClass<SpriteRenderer>();
	//15. Texture
	RegisterClass<Texture>();
	//16. Texture2D
	RegisterClass<Texture2D>();
	//17. RenderTexture
	RegisterClass<RenderTexture>();
	//18. Transform
	RegisterClass<Transform>();
	//19. UI::RectTransform
	RegisterClass<UI::RectTransform>();
	//20. AudioClip
	RegisterClass<AudioClip>();
	//21. SampleClip
	RegisterClass<SampleClip>();
	//22. AudioSource
	RegisterClass<AudioSource>();
	//23. AudioBehaviour
	RegisterClass<AudioBehaviour>();
	//24. Animator
	RegisterClass<Animator>();
	//25. TextRendering::Font
	RegisterClass<TextRendering::Font>();
	//26. UI::Canvas
	RegisterClass<UI::Canvas>();
	//27. UI::CanvasGroup
	RegisterClass<UI::CanvasGroup>();
	//28. UI::CanvasRenderer
	RegisterClass<UI::CanvasRenderer>();
	//29. Collider2D
	RegisterClass<Collider2D>();
	//30. PreloadData
	RegisterClass<PreloadData>();
	//31. Cubemap
	RegisterClass<Cubemap>();
	//32. Texture3D
	RegisterClass<Texture3D>();
	//33. Texture2DArray
	RegisterClass<Texture2DArray>();
	//34. MeshFilter
	RegisterClass<MeshFilter>();
	//35. MeshRenderer
	RegisterClass<MeshRenderer>();
	//36. LowerResBlitTexture
	RegisterClass<LowerResBlitTexture>();
	//37. TimeManager
	RegisterClass<TimeManager>();
	//38. GlobalGameManager
	RegisterClass<GlobalGameManager>();
	//39. GameManager
	RegisterClass<GameManager>();
	//40. AudioManager
	RegisterClass<AudioManager>();
	//41. InputManager
	RegisterClass<InputManager>();
	//42. Physics2DSettings
	RegisterClass<Physics2DSettings>();
	//43. GraphicsSettings
	RegisterClass<GraphicsSettings>();
	//44. QualitySettings
	RegisterClass<QualitySettings>();
	//45. TextAsset
	RegisterClass<TextAsset>();
	//46. TagManager
	RegisterClass<TagManager>();
	//47. ScriptMapper
	RegisterClass<ScriptMapper>();
	//48. DelayedCallManager
	RegisterClass<DelayedCallManager>();
	//49. MonoScript
	RegisterClass<MonoScript>();
	//50. MonoManager
	RegisterClass<MonoManager>();
	//51. PlayerSettings
	RegisterClass<PlayerSettings>();
	//52. BuildSettings
	RegisterClass<BuildSettings>();
	//53. ResourceManager
	RegisterClass<ResourceManager>();
	//54. NetworkManager
	RegisterClass<NetworkManager>();
	//55. MasterServerInterface
	RegisterClass<MasterServerInterface>();
	//56. RuntimeInitializeOnLoadManager
	RegisterClass<RuntimeInitializeOnLoadManager>();
	//57. CloudWebServicesManager
	RegisterClass<CloudWebServicesManager>();
	//58. UnityConnectSettings
	RegisterClass<UnityConnectSettings>();
	//59. LevelGameManager
	RegisterClass<LevelGameManager>();
	//60. CircleCollider2D
	RegisterClass<CircleCollider2D>();
	//61. AnimationClip
	RegisterClass<AnimationClip>();
	//62. Motion
	RegisterClass<Motion>();
	//63. AudioListener
	RegisterClass<AudioListener>();
	//64. AnimatorController
	RegisterClass<AnimatorController>();
	//65. RuntimeAnimatorController
	RegisterClass<RuntimeAnimatorController>();
	//66. RenderSettings
	RegisterClass<RenderSettings>();
	//67. FlareLayer
	RegisterClass<FlareLayer>();
	//68. LightmapSettings
	RegisterClass<LightmapSettings>();
	//69. BoxCollider2D
	RegisterClass<BoxCollider2D>();
	//70. CapsuleCollider2D
	RegisterClass<CapsuleCollider2D>();

}
