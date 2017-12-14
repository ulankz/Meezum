#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "UnityEngine_UnityEngine_Vector22243707579.h"

// UnityEngine.GameObject
struct GameObject_t1756533147;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Swipe
struct  Swipe_t3475047630  : public MonoBehaviour_t1158329972
{
public:
	// System.Boolean Swipe::tap
	bool ___tap_2;
	// System.Boolean Swipe::swipeLeft
	bool ___swipeLeft_3;
	// System.Boolean Swipe::swipeRight
	bool ___swipeRight_4;
	// UnityEngine.Vector2 Swipe::startTouch
	Vector2_t2243707579  ___startTouch_5;
	// UnityEngine.Vector2 Swipe::swipeDelta
	Vector2_t2243707579  ___swipeDelta_6;
	// System.Boolean Swipe::isDraging
	bool ___isDraging_7;
	// UnityEngine.GameObject Swipe::gamePanel
	GameObject_t1756533147 * ___gamePanel_8;
	// UnityEngine.GameObject Swipe::cupboardPanel
	GameObject_t1756533147 * ___cupboardPanel_9;
	// UnityEngine.GameObject Swipe::tvPanel
	GameObject_t1756533147 * ___tvPanel_10;
	// UnityEngine.GameObject Swipe::optionsPanel
	GameObject_t1756533147 * ___optionsPanel_11;

public:
	inline static int32_t get_offset_of_tap_2() { return static_cast<int32_t>(offsetof(Swipe_t3475047630, ___tap_2)); }
	inline bool get_tap_2() const { return ___tap_2; }
	inline bool* get_address_of_tap_2() { return &___tap_2; }
	inline void set_tap_2(bool value)
	{
		___tap_2 = value;
	}

	inline static int32_t get_offset_of_swipeLeft_3() { return static_cast<int32_t>(offsetof(Swipe_t3475047630, ___swipeLeft_3)); }
	inline bool get_swipeLeft_3() const { return ___swipeLeft_3; }
	inline bool* get_address_of_swipeLeft_3() { return &___swipeLeft_3; }
	inline void set_swipeLeft_3(bool value)
	{
		___swipeLeft_3 = value;
	}

	inline static int32_t get_offset_of_swipeRight_4() { return static_cast<int32_t>(offsetof(Swipe_t3475047630, ___swipeRight_4)); }
	inline bool get_swipeRight_4() const { return ___swipeRight_4; }
	inline bool* get_address_of_swipeRight_4() { return &___swipeRight_4; }
	inline void set_swipeRight_4(bool value)
	{
		___swipeRight_4 = value;
	}

	inline static int32_t get_offset_of_startTouch_5() { return static_cast<int32_t>(offsetof(Swipe_t3475047630, ___startTouch_5)); }
	inline Vector2_t2243707579  get_startTouch_5() const { return ___startTouch_5; }
	inline Vector2_t2243707579 * get_address_of_startTouch_5() { return &___startTouch_5; }
	inline void set_startTouch_5(Vector2_t2243707579  value)
	{
		___startTouch_5 = value;
	}

	inline static int32_t get_offset_of_swipeDelta_6() { return static_cast<int32_t>(offsetof(Swipe_t3475047630, ___swipeDelta_6)); }
	inline Vector2_t2243707579  get_swipeDelta_6() const { return ___swipeDelta_6; }
	inline Vector2_t2243707579 * get_address_of_swipeDelta_6() { return &___swipeDelta_6; }
	inline void set_swipeDelta_6(Vector2_t2243707579  value)
	{
		___swipeDelta_6 = value;
	}

	inline static int32_t get_offset_of_isDraging_7() { return static_cast<int32_t>(offsetof(Swipe_t3475047630, ___isDraging_7)); }
	inline bool get_isDraging_7() const { return ___isDraging_7; }
	inline bool* get_address_of_isDraging_7() { return &___isDraging_7; }
	inline void set_isDraging_7(bool value)
	{
		___isDraging_7 = value;
	}

	inline static int32_t get_offset_of_gamePanel_8() { return static_cast<int32_t>(offsetof(Swipe_t3475047630, ___gamePanel_8)); }
	inline GameObject_t1756533147 * get_gamePanel_8() const { return ___gamePanel_8; }
	inline GameObject_t1756533147 ** get_address_of_gamePanel_8() { return &___gamePanel_8; }
	inline void set_gamePanel_8(GameObject_t1756533147 * value)
	{
		___gamePanel_8 = value;
		Il2CppCodeGenWriteBarrier(&___gamePanel_8, value);
	}

	inline static int32_t get_offset_of_cupboardPanel_9() { return static_cast<int32_t>(offsetof(Swipe_t3475047630, ___cupboardPanel_9)); }
	inline GameObject_t1756533147 * get_cupboardPanel_9() const { return ___cupboardPanel_9; }
	inline GameObject_t1756533147 ** get_address_of_cupboardPanel_9() { return &___cupboardPanel_9; }
	inline void set_cupboardPanel_9(GameObject_t1756533147 * value)
	{
		___cupboardPanel_9 = value;
		Il2CppCodeGenWriteBarrier(&___cupboardPanel_9, value);
	}

	inline static int32_t get_offset_of_tvPanel_10() { return static_cast<int32_t>(offsetof(Swipe_t3475047630, ___tvPanel_10)); }
	inline GameObject_t1756533147 * get_tvPanel_10() const { return ___tvPanel_10; }
	inline GameObject_t1756533147 ** get_address_of_tvPanel_10() { return &___tvPanel_10; }
	inline void set_tvPanel_10(GameObject_t1756533147 * value)
	{
		___tvPanel_10 = value;
		Il2CppCodeGenWriteBarrier(&___tvPanel_10, value);
	}

	inline static int32_t get_offset_of_optionsPanel_11() { return static_cast<int32_t>(offsetof(Swipe_t3475047630, ___optionsPanel_11)); }
	inline GameObject_t1756533147 * get_optionsPanel_11() const { return ___optionsPanel_11; }
	inline GameObject_t1756533147 ** get_address_of_optionsPanel_11() { return &___optionsPanel_11; }
	inline void set_optionsPanel_11(GameObject_t1756533147 * value)
	{
		___optionsPanel_11 = value;
		Il2CppCodeGenWriteBarrier(&___optionsPanel_11, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
