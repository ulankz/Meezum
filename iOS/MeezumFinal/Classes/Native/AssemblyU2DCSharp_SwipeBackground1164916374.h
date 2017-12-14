#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "UnityEngine_UnityEngine_Vector32243707580.h"

// Swipe
struct Swipe_t3475047630;
// UnityEngine.Sprite
struct Sprite_t309593783;
// UnityEngine.GameObject
struct GameObject_t1756533147;
// UnityEngine.Camera
struct Camera_t189460977;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// SwipeBackground
struct  SwipeBackground_t1164916374  : public MonoBehaviour_t1158329972
{
public:
	// Swipe SwipeBackground::swipeControls
	Swipe_t3475047630 * ___swipeControls_2;
	// System.Int32 SwipeBackground::swipeIndex
	int32_t ___swipeIndex_3;
	// UnityEngine.Sprite SwipeBackground::sprite
	Sprite_t309593783 * ___sprite_4;
	// UnityEngine.GameObject SwipeBackground::other
	GameObject_t1756533147 * ___other_5;
	// UnityEngine.Camera SwipeBackground::camera
	Camera_t189460977 * ___camera_6;
	// UnityEngine.Vector3 SwipeBackground::camBound
	Vector3_t2243707580  ___camBound_7;

public:
	inline static int32_t get_offset_of_swipeControls_2() { return static_cast<int32_t>(offsetof(SwipeBackground_t1164916374, ___swipeControls_2)); }
	inline Swipe_t3475047630 * get_swipeControls_2() const { return ___swipeControls_2; }
	inline Swipe_t3475047630 ** get_address_of_swipeControls_2() { return &___swipeControls_2; }
	inline void set_swipeControls_2(Swipe_t3475047630 * value)
	{
		___swipeControls_2 = value;
		Il2CppCodeGenWriteBarrier(&___swipeControls_2, value);
	}

	inline static int32_t get_offset_of_swipeIndex_3() { return static_cast<int32_t>(offsetof(SwipeBackground_t1164916374, ___swipeIndex_3)); }
	inline int32_t get_swipeIndex_3() const { return ___swipeIndex_3; }
	inline int32_t* get_address_of_swipeIndex_3() { return &___swipeIndex_3; }
	inline void set_swipeIndex_3(int32_t value)
	{
		___swipeIndex_3 = value;
	}

	inline static int32_t get_offset_of_sprite_4() { return static_cast<int32_t>(offsetof(SwipeBackground_t1164916374, ___sprite_4)); }
	inline Sprite_t309593783 * get_sprite_4() const { return ___sprite_4; }
	inline Sprite_t309593783 ** get_address_of_sprite_4() { return &___sprite_4; }
	inline void set_sprite_4(Sprite_t309593783 * value)
	{
		___sprite_4 = value;
		Il2CppCodeGenWriteBarrier(&___sprite_4, value);
	}

	inline static int32_t get_offset_of_other_5() { return static_cast<int32_t>(offsetof(SwipeBackground_t1164916374, ___other_5)); }
	inline GameObject_t1756533147 * get_other_5() const { return ___other_5; }
	inline GameObject_t1756533147 ** get_address_of_other_5() { return &___other_5; }
	inline void set_other_5(GameObject_t1756533147 * value)
	{
		___other_5 = value;
		Il2CppCodeGenWriteBarrier(&___other_5, value);
	}

	inline static int32_t get_offset_of_camera_6() { return static_cast<int32_t>(offsetof(SwipeBackground_t1164916374, ___camera_6)); }
	inline Camera_t189460977 * get_camera_6() const { return ___camera_6; }
	inline Camera_t189460977 ** get_address_of_camera_6() { return &___camera_6; }
	inline void set_camera_6(Camera_t189460977 * value)
	{
		___camera_6 = value;
		Il2CppCodeGenWriteBarrier(&___camera_6, value);
	}

	inline static int32_t get_offset_of_camBound_7() { return static_cast<int32_t>(offsetof(SwipeBackground_t1164916374, ___camBound_7)); }
	inline Vector3_t2243707580  get_camBound_7() const { return ___camBound_7; }
	inline Vector3_t2243707580 * get_address_of_camBound_7() { return &___camBound_7; }
	inline void set_camBound_7(Vector3_t2243707580  value)
	{
		___camBound_7 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
