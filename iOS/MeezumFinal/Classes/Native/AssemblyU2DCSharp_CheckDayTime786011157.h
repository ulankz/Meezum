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
#include "mscorlib_System_TimeSpan3430258949.h"

// UnityEngine.GameObject
struct GameObject_t1756533147;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// CheckDayTime
struct  CheckDayTime_t786011157  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject CheckDayTime::bg_day
	GameObject_t1756533147 * ___bg_day_2;
	// UnityEngine.GameObject CheckDayTime::main_tree_day
	GameObject_t1756533147 * ___main_tree_day_3;
	// UnityEngine.GameObject CheckDayTime::bg_night
	GameObject_t1756533147 * ___bg_night_4;
	// UnityEngine.GameObject CheckDayTime::main_tree_night
	GameObject_t1756533147 * ___main_tree_night_5;
	// UnityEngine.Vector2 CheckDayTime::dayTimeSpan
	Vector2_t2243707579  ___dayTimeSpan_6;
	// System.TimeSpan CheckDayTime::minTime
	TimeSpan_t3430258949  ___minTime_7;
	// System.TimeSpan CheckDayTime::maxTime
	TimeSpan_t3430258949  ___maxTime_8;
	// System.Int32 CheckDayTime::index
	int32_t ___index_9;

public:
	inline static int32_t get_offset_of_bg_day_2() { return static_cast<int32_t>(offsetof(CheckDayTime_t786011157, ___bg_day_2)); }
	inline GameObject_t1756533147 * get_bg_day_2() const { return ___bg_day_2; }
	inline GameObject_t1756533147 ** get_address_of_bg_day_2() { return &___bg_day_2; }
	inline void set_bg_day_2(GameObject_t1756533147 * value)
	{
		___bg_day_2 = value;
		Il2CppCodeGenWriteBarrier(&___bg_day_2, value);
	}

	inline static int32_t get_offset_of_main_tree_day_3() { return static_cast<int32_t>(offsetof(CheckDayTime_t786011157, ___main_tree_day_3)); }
	inline GameObject_t1756533147 * get_main_tree_day_3() const { return ___main_tree_day_3; }
	inline GameObject_t1756533147 ** get_address_of_main_tree_day_3() { return &___main_tree_day_3; }
	inline void set_main_tree_day_3(GameObject_t1756533147 * value)
	{
		___main_tree_day_3 = value;
		Il2CppCodeGenWriteBarrier(&___main_tree_day_3, value);
	}

	inline static int32_t get_offset_of_bg_night_4() { return static_cast<int32_t>(offsetof(CheckDayTime_t786011157, ___bg_night_4)); }
	inline GameObject_t1756533147 * get_bg_night_4() const { return ___bg_night_4; }
	inline GameObject_t1756533147 ** get_address_of_bg_night_4() { return &___bg_night_4; }
	inline void set_bg_night_4(GameObject_t1756533147 * value)
	{
		___bg_night_4 = value;
		Il2CppCodeGenWriteBarrier(&___bg_night_4, value);
	}

	inline static int32_t get_offset_of_main_tree_night_5() { return static_cast<int32_t>(offsetof(CheckDayTime_t786011157, ___main_tree_night_5)); }
	inline GameObject_t1756533147 * get_main_tree_night_5() const { return ___main_tree_night_5; }
	inline GameObject_t1756533147 ** get_address_of_main_tree_night_5() { return &___main_tree_night_5; }
	inline void set_main_tree_night_5(GameObject_t1756533147 * value)
	{
		___main_tree_night_5 = value;
		Il2CppCodeGenWriteBarrier(&___main_tree_night_5, value);
	}

	inline static int32_t get_offset_of_dayTimeSpan_6() { return static_cast<int32_t>(offsetof(CheckDayTime_t786011157, ___dayTimeSpan_6)); }
	inline Vector2_t2243707579  get_dayTimeSpan_6() const { return ___dayTimeSpan_6; }
	inline Vector2_t2243707579 * get_address_of_dayTimeSpan_6() { return &___dayTimeSpan_6; }
	inline void set_dayTimeSpan_6(Vector2_t2243707579  value)
	{
		___dayTimeSpan_6 = value;
	}

	inline static int32_t get_offset_of_minTime_7() { return static_cast<int32_t>(offsetof(CheckDayTime_t786011157, ___minTime_7)); }
	inline TimeSpan_t3430258949  get_minTime_7() const { return ___minTime_7; }
	inline TimeSpan_t3430258949 * get_address_of_minTime_7() { return &___minTime_7; }
	inline void set_minTime_7(TimeSpan_t3430258949  value)
	{
		___minTime_7 = value;
	}

	inline static int32_t get_offset_of_maxTime_8() { return static_cast<int32_t>(offsetof(CheckDayTime_t786011157, ___maxTime_8)); }
	inline TimeSpan_t3430258949  get_maxTime_8() const { return ___maxTime_8; }
	inline TimeSpan_t3430258949 * get_address_of_maxTime_8() { return &___maxTime_8; }
	inline void set_maxTime_8(TimeSpan_t3430258949  value)
	{
		___maxTime_8 = value;
	}

	inline static int32_t get_offset_of_index_9() { return static_cast<int32_t>(offsetof(CheckDayTime_t786011157, ___index_9)); }
	inline int32_t get_index_9() const { return ___index_9; }
	inline int32_t* get_address_of_index_9() { return &___index_9; }
	inline void set_index_9(int32_t value)
	{
		___index_9 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
