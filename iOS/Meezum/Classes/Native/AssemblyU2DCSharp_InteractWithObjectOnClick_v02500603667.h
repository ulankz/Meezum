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
#include "UnityEngine_UnityEngine_Vector32243707580.h"

// ScoreManager
struct ScoreManager_t3573108141;
// System.Collections.Generic.List`1<MessItem>
struct List_1_t3818857439;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// InteractWithObjectOnClick_v02
struct  InteractWithObjectOnClick_v02_t500603667  : public MonoBehaviour_t1158329972
{
public:
	// System.Int32 InteractWithObjectOnClick_v02::messItemIndex
	int32_t ___messItemIndex_2;
	// UnityEngine.Vector2 InteractWithObjectOnClick_v02::offset
	Vector2_t2243707579  ___offset_3;
	// UnityEngine.Vector2 InteractWithObjectOnClick_v02::newScale
	Vector2_t2243707579  ___newScale_4;
	// UnityEngine.Vector3 InteractWithObjectOnClick_v02::newRotation
	Vector3_t2243707580  ___newRotation_5;
	// System.Boolean InteractWithObjectOnClick_v02::isTransformRequired
	bool ___isTransformRequired_6;
	// System.Boolean InteractWithObjectOnClick_v02::hideAfterInteraction
	bool ___hideAfterInteraction_7;
	// System.Boolean InteractWithObjectOnClick_v02::isSubstituteRequired
	bool ___isSubstituteRequired_8;
	// ScoreManager InteractWithObjectOnClick_v02::scoreManager
	ScoreManager_t3573108141 * ___scoreManager_9;
	// System.Collections.Generic.List`1<MessItem> InteractWithObjectOnClick_v02::messItems
	List_1_t3818857439 * ___messItems_10;

public:
	inline static int32_t get_offset_of_messItemIndex_2() { return static_cast<int32_t>(offsetof(InteractWithObjectOnClick_v02_t500603667, ___messItemIndex_2)); }
	inline int32_t get_messItemIndex_2() const { return ___messItemIndex_2; }
	inline int32_t* get_address_of_messItemIndex_2() { return &___messItemIndex_2; }
	inline void set_messItemIndex_2(int32_t value)
	{
		___messItemIndex_2 = value;
	}

	inline static int32_t get_offset_of_offset_3() { return static_cast<int32_t>(offsetof(InteractWithObjectOnClick_v02_t500603667, ___offset_3)); }
	inline Vector2_t2243707579  get_offset_3() const { return ___offset_3; }
	inline Vector2_t2243707579 * get_address_of_offset_3() { return &___offset_3; }
	inline void set_offset_3(Vector2_t2243707579  value)
	{
		___offset_3 = value;
	}

	inline static int32_t get_offset_of_newScale_4() { return static_cast<int32_t>(offsetof(InteractWithObjectOnClick_v02_t500603667, ___newScale_4)); }
	inline Vector2_t2243707579  get_newScale_4() const { return ___newScale_4; }
	inline Vector2_t2243707579 * get_address_of_newScale_4() { return &___newScale_4; }
	inline void set_newScale_4(Vector2_t2243707579  value)
	{
		___newScale_4 = value;
	}

	inline static int32_t get_offset_of_newRotation_5() { return static_cast<int32_t>(offsetof(InteractWithObjectOnClick_v02_t500603667, ___newRotation_5)); }
	inline Vector3_t2243707580  get_newRotation_5() const { return ___newRotation_5; }
	inline Vector3_t2243707580 * get_address_of_newRotation_5() { return &___newRotation_5; }
	inline void set_newRotation_5(Vector3_t2243707580  value)
	{
		___newRotation_5 = value;
	}

	inline static int32_t get_offset_of_isTransformRequired_6() { return static_cast<int32_t>(offsetof(InteractWithObjectOnClick_v02_t500603667, ___isTransformRequired_6)); }
	inline bool get_isTransformRequired_6() const { return ___isTransformRequired_6; }
	inline bool* get_address_of_isTransformRequired_6() { return &___isTransformRequired_6; }
	inline void set_isTransformRequired_6(bool value)
	{
		___isTransformRequired_6 = value;
	}

	inline static int32_t get_offset_of_hideAfterInteraction_7() { return static_cast<int32_t>(offsetof(InteractWithObjectOnClick_v02_t500603667, ___hideAfterInteraction_7)); }
	inline bool get_hideAfterInteraction_7() const { return ___hideAfterInteraction_7; }
	inline bool* get_address_of_hideAfterInteraction_7() { return &___hideAfterInteraction_7; }
	inline void set_hideAfterInteraction_7(bool value)
	{
		___hideAfterInteraction_7 = value;
	}

	inline static int32_t get_offset_of_isSubstituteRequired_8() { return static_cast<int32_t>(offsetof(InteractWithObjectOnClick_v02_t500603667, ___isSubstituteRequired_8)); }
	inline bool get_isSubstituteRequired_8() const { return ___isSubstituteRequired_8; }
	inline bool* get_address_of_isSubstituteRequired_8() { return &___isSubstituteRequired_8; }
	inline void set_isSubstituteRequired_8(bool value)
	{
		___isSubstituteRequired_8 = value;
	}

	inline static int32_t get_offset_of_scoreManager_9() { return static_cast<int32_t>(offsetof(InteractWithObjectOnClick_v02_t500603667, ___scoreManager_9)); }
	inline ScoreManager_t3573108141 * get_scoreManager_9() const { return ___scoreManager_9; }
	inline ScoreManager_t3573108141 ** get_address_of_scoreManager_9() { return &___scoreManager_9; }
	inline void set_scoreManager_9(ScoreManager_t3573108141 * value)
	{
		___scoreManager_9 = value;
		Il2CppCodeGenWriteBarrier(&___scoreManager_9, value);
	}

	inline static int32_t get_offset_of_messItems_10() { return static_cast<int32_t>(offsetof(InteractWithObjectOnClick_v02_t500603667, ___messItems_10)); }
	inline List_1_t3818857439 * get_messItems_10() const { return ___messItems_10; }
	inline List_1_t3818857439 ** get_address_of_messItems_10() { return &___messItems_10; }
	inline void set_messItems_10(List_1_t3818857439 * value)
	{
		___messItems_10 = value;
		Il2CppCodeGenWriteBarrier(&___messItems_10, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
