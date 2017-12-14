#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// System.Collections.Generic.List`1<UnityEngine.GameObject>
struct List_1_t1125654279;
// UnityEngine.GameObject
struct GameObject_t1756533147;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// SwitchDayNight
struct  SwitchDayNight_t2451155140  : public MonoBehaviour_t1158329972
{
public:
	// System.Collections.Generic.List`1<UnityEngine.GameObject> SwitchDayNight::dayItems
	List_1_t1125654279 * ___dayItems_2;
	// System.Collections.Generic.List`1<UnityEngine.GameObject> SwitchDayNight::nightItems
	List_1_t1125654279 * ___nightItems_3;
	// UnityEngine.GameObject SwitchDayNight::celestialBody
	GameObject_t1756533147 * ___celestialBody_4;
	// UnityEngine.GameObject SwitchDayNight::helper
	GameObject_t1756533147 * ___helper_5;

public:
	inline static int32_t get_offset_of_dayItems_2() { return static_cast<int32_t>(offsetof(SwitchDayNight_t2451155140, ___dayItems_2)); }
	inline List_1_t1125654279 * get_dayItems_2() const { return ___dayItems_2; }
	inline List_1_t1125654279 ** get_address_of_dayItems_2() { return &___dayItems_2; }
	inline void set_dayItems_2(List_1_t1125654279 * value)
	{
		___dayItems_2 = value;
		Il2CppCodeGenWriteBarrier(&___dayItems_2, value);
	}

	inline static int32_t get_offset_of_nightItems_3() { return static_cast<int32_t>(offsetof(SwitchDayNight_t2451155140, ___nightItems_3)); }
	inline List_1_t1125654279 * get_nightItems_3() const { return ___nightItems_3; }
	inline List_1_t1125654279 ** get_address_of_nightItems_3() { return &___nightItems_3; }
	inline void set_nightItems_3(List_1_t1125654279 * value)
	{
		___nightItems_3 = value;
		Il2CppCodeGenWriteBarrier(&___nightItems_3, value);
	}

	inline static int32_t get_offset_of_celestialBody_4() { return static_cast<int32_t>(offsetof(SwitchDayNight_t2451155140, ___celestialBody_4)); }
	inline GameObject_t1756533147 * get_celestialBody_4() const { return ___celestialBody_4; }
	inline GameObject_t1756533147 ** get_address_of_celestialBody_4() { return &___celestialBody_4; }
	inline void set_celestialBody_4(GameObject_t1756533147 * value)
	{
		___celestialBody_4 = value;
		Il2CppCodeGenWriteBarrier(&___celestialBody_4, value);
	}

	inline static int32_t get_offset_of_helper_5() { return static_cast<int32_t>(offsetof(SwitchDayNight_t2451155140, ___helper_5)); }
	inline GameObject_t1756533147 * get_helper_5() const { return ___helper_5; }
	inline GameObject_t1756533147 ** get_address_of_helper_5() { return &___helper_5; }
	inline void set_helper_5(GameObject_t1756533147 * value)
	{
		___helper_5 = value;
		Il2CppCodeGenWriteBarrier(&___helper_5, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
