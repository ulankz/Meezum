#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.GameObject
struct GameObject_t1756533147;
// System.Collections.Generic.List`1<UnityEngine.Collider2D>
struct List_1_t15182870;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ActivatePanel
struct  ActivatePanel_t3517023317  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject ActivatePanel::panel
	GameObject_t1756533147 * ___panel_2;
	// UnityEngine.GameObject ActivatePanel::helper
	GameObject_t1756533147 * ___helper_3;
	// System.Collections.Generic.List`1<UnityEngine.Collider2D> ActivatePanel::colliders
	List_1_t15182870 * ___colliders_4;

public:
	inline static int32_t get_offset_of_panel_2() { return static_cast<int32_t>(offsetof(ActivatePanel_t3517023317, ___panel_2)); }
	inline GameObject_t1756533147 * get_panel_2() const { return ___panel_2; }
	inline GameObject_t1756533147 ** get_address_of_panel_2() { return &___panel_2; }
	inline void set_panel_2(GameObject_t1756533147 * value)
	{
		___panel_2 = value;
		Il2CppCodeGenWriteBarrier(&___panel_2, value);
	}

	inline static int32_t get_offset_of_helper_3() { return static_cast<int32_t>(offsetof(ActivatePanel_t3517023317, ___helper_3)); }
	inline GameObject_t1756533147 * get_helper_3() const { return ___helper_3; }
	inline GameObject_t1756533147 ** get_address_of_helper_3() { return &___helper_3; }
	inline void set_helper_3(GameObject_t1756533147 * value)
	{
		___helper_3 = value;
		Il2CppCodeGenWriteBarrier(&___helper_3, value);
	}

	inline static int32_t get_offset_of_colliders_4() { return static_cast<int32_t>(offsetof(ActivatePanel_t3517023317, ___colliders_4)); }
	inline List_1_t15182870 * get_colliders_4() const { return ___colliders_4; }
	inline List_1_t15182870 ** get_address_of_colliders_4() { return &___colliders_4; }
	inline void set_colliders_4(List_1_t15182870 * value)
	{
		___colliders_4 = value;
		Il2CppCodeGenWriteBarrier(&___colliders_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
