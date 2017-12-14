#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object2689449295.h"

// System.String
struct String_t;
// System.Collections.Generic.List`1<MessItem>
struct List_1_t3818857439;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// PlayerEntry
struct  PlayerEntry_t2004536889  : public Il2CppObject
{
public:
	// System.String PlayerEntry::playerName
	String_t* ___playerName_0;
	// System.Int32 PlayerEntry::age
	int32_t ___age_1;
	// System.Int32 PlayerEntry::scores
	int32_t ___scores_2;
	// System.Int32 PlayerEntry::cookies
	int32_t ___cookies_3;
	// System.Int32 PlayerEntry::eatenCookies
	int32_t ___eatenCookies_4;
	// System.Int32 PlayerEntry::boughtCookies
	int32_t ___boughtCookies_5;
	// System.Int32 PlayerEntry::cleanedMessItems
	int32_t ___cleanedMessItems_6;
	// System.Collections.Generic.List`1<MessItem> PlayerEntry::messItems
	List_1_t3818857439 * ___messItems_7;

public:
	inline static int32_t get_offset_of_playerName_0() { return static_cast<int32_t>(offsetof(PlayerEntry_t2004536889, ___playerName_0)); }
	inline String_t* get_playerName_0() const { return ___playerName_0; }
	inline String_t** get_address_of_playerName_0() { return &___playerName_0; }
	inline void set_playerName_0(String_t* value)
	{
		___playerName_0 = value;
		Il2CppCodeGenWriteBarrier(&___playerName_0, value);
	}

	inline static int32_t get_offset_of_age_1() { return static_cast<int32_t>(offsetof(PlayerEntry_t2004536889, ___age_1)); }
	inline int32_t get_age_1() const { return ___age_1; }
	inline int32_t* get_address_of_age_1() { return &___age_1; }
	inline void set_age_1(int32_t value)
	{
		___age_1 = value;
	}

	inline static int32_t get_offset_of_scores_2() { return static_cast<int32_t>(offsetof(PlayerEntry_t2004536889, ___scores_2)); }
	inline int32_t get_scores_2() const { return ___scores_2; }
	inline int32_t* get_address_of_scores_2() { return &___scores_2; }
	inline void set_scores_2(int32_t value)
	{
		___scores_2 = value;
	}

	inline static int32_t get_offset_of_cookies_3() { return static_cast<int32_t>(offsetof(PlayerEntry_t2004536889, ___cookies_3)); }
	inline int32_t get_cookies_3() const { return ___cookies_3; }
	inline int32_t* get_address_of_cookies_3() { return &___cookies_3; }
	inline void set_cookies_3(int32_t value)
	{
		___cookies_3 = value;
	}

	inline static int32_t get_offset_of_eatenCookies_4() { return static_cast<int32_t>(offsetof(PlayerEntry_t2004536889, ___eatenCookies_4)); }
	inline int32_t get_eatenCookies_4() const { return ___eatenCookies_4; }
	inline int32_t* get_address_of_eatenCookies_4() { return &___eatenCookies_4; }
	inline void set_eatenCookies_4(int32_t value)
	{
		___eatenCookies_4 = value;
	}

	inline static int32_t get_offset_of_boughtCookies_5() { return static_cast<int32_t>(offsetof(PlayerEntry_t2004536889, ___boughtCookies_5)); }
	inline int32_t get_boughtCookies_5() const { return ___boughtCookies_5; }
	inline int32_t* get_address_of_boughtCookies_5() { return &___boughtCookies_5; }
	inline void set_boughtCookies_5(int32_t value)
	{
		___boughtCookies_5 = value;
	}

	inline static int32_t get_offset_of_cleanedMessItems_6() { return static_cast<int32_t>(offsetof(PlayerEntry_t2004536889, ___cleanedMessItems_6)); }
	inline int32_t get_cleanedMessItems_6() const { return ___cleanedMessItems_6; }
	inline int32_t* get_address_of_cleanedMessItems_6() { return &___cleanedMessItems_6; }
	inline void set_cleanedMessItems_6(int32_t value)
	{
		___cleanedMessItems_6 = value;
	}

	inline static int32_t get_offset_of_messItems_7() { return static_cast<int32_t>(offsetof(PlayerEntry_t2004536889, ___messItems_7)); }
	inline List_1_t3818857439 * get_messItems_7() const { return ___messItems_7; }
	inline List_1_t3818857439 ** get_address_of_messItems_7() { return &___messItems_7; }
	inline void set_messItems_7(List_1_t3818857439 * value)
	{
		___messItems_7 = value;
		Il2CppCodeGenWriteBarrier(&___messItems_7, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
