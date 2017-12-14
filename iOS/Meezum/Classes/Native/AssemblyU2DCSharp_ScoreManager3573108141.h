#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// System.Collections.Generic.List`1<UnityEngine.Sprite>
struct List_1_t3973682211;
// PlayerEntry
struct PlayerEntry_t2004536889;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ScoreManager
struct  ScoreManager_t3573108141  : public MonoBehaviour_t1158329972
{
public:
	// System.Collections.Generic.List`1<UnityEngine.Sprite> ScoreManager::digits
	List_1_t3973682211 * ___digits_2;
	// PlayerEntry ScoreManager::player
	PlayerEntry_t2004536889 * ___player_3;

public:
	inline static int32_t get_offset_of_digits_2() { return static_cast<int32_t>(offsetof(ScoreManager_t3573108141, ___digits_2)); }
	inline List_1_t3973682211 * get_digits_2() const { return ___digits_2; }
	inline List_1_t3973682211 ** get_address_of_digits_2() { return &___digits_2; }
	inline void set_digits_2(List_1_t3973682211 * value)
	{
		___digits_2 = value;
		Il2CppCodeGenWriteBarrier(&___digits_2, value);
	}

	inline static int32_t get_offset_of_player_3() { return static_cast<int32_t>(offsetof(ScoreManager_t3573108141, ___player_3)); }
	inline PlayerEntry_t2004536889 * get_player_3() const { return ___player_3; }
	inline PlayerEntry_t2004536889 ** get_address_of_player_3() { return &___player_3; }
	inline void set_player_3(PlayerEntry_t2004536889 * value)
	{
		___player_3 = value;
		Il2CppCodeGenWriteBarrier(&___player_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
