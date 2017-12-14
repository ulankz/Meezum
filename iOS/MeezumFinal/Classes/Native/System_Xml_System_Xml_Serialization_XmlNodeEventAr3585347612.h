#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_EventArgs3289624707.h"
#include "System_Xml_System_Xml_XmlNodeType739504597.h"

// System.String
struct String_t;
// System.Object
struct Il2CppObject;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.XmlNodeEventArgs
struct  XmlNodeEventArgs_t3585347612  : public EventArgs_t3289624707
{
public:
	// System.Int32 System.Xml.Serialization.XmlNodeEventArgs::linenumber
	int32_t ___linenumber_1;
	// System.Int32 System.Xml.Serialization.XmlNodeEventArgs::lineposition
	int32_t ___lineposition_2;
	// System.String System.Xml.Serialization.XmlNodeEventArgs::localname
	String_t* ___localname_3;
	// System.String System.Xml.Serialization.XmlNodeEventArgs::name
	String_t* ___name_4;
	// System.String System.Xml.Serialization.XmlNodeEventArgs::nsuri
	String_t* ___nsuri_5;
	// System.Xml.XmlNodeType System.Xml.Serialization.XmlNodeEventArgs::nodetype
	int32_t ___nodetype_6;
	// System.Object System.Xml.Serialization.XmlNodeEventArgs::source
	Il2CppObject * ___source_7;
	// System.String System.Xml.Serialization.XmlNodeEventArgs::text
	String_t* ___text_8;

public:
	inline static int32_t get_offset_of_linenumber_1() { return static_cast<int32_t>(offsetof(XmlNodeEventArgs_t3585347612, ___linenumber_1)); }
	inline int32_t get_linenumber_1() const { return ___linenumber_1; }
	inline int32_t* get_address_of_linenumber_1() { return &___linenumber_1; }
	inline void set_linenumber_1(int32_t value)
	{
		___linenumber_1 = value;
	}

	inline static int32_t get_offset_of_lineposition_2() { return static_cast<int32_t>(offsetof(XmlNodeEventArgs_t3585347612, ___lineposition_2)); }
	inline int32_t get_lineposition_2() const { return ___lineposition_2; }
	inline int32_t* get_address_of_lineposition_2() { return &___lineposition_2; }
	inline void set_lineposition_2(int32_t value)
	{
		___lineposition_2 = value;
	}

	inline static int32_t get_offset_of_localname_3() { return static_cast<int32_t>(offsetof(XmlNodeEventArgs_t3585347612, ___localname_3)); }
	inline String_t* get_localname_3() const { return ___localname_3; }
	inline String_t** get_address_of_localname_3() { return &___localname_3; }
	inline void set_localname_3(String_t* value)
	{
		___localname_3 = value;
		Il2CppCodeGenWriteBarrier(&___localname_3, value);
	}

	inline static int32_t get_offset_of_name_4() { return static_cast<int32_t>(offsetof(XmlNodeEventArgs_t3585347612, ___name_4)); }
	inline String_t* get_name_4() const { return ___name_4; }
	inline String_t** get_address_of_name_4() { return &___name_4; }
	inline void set_name_4(String_t* value)
	{
		___name_4 = value;
		Il2CppCodeGenWriteBarrier(&___name_4, value);
	}

	inline static int32_t get_offset_of_nsuri_5() { return static_cast<int32_t>(offsetof(XmlNodeEventArgs_t3585347612, ___nsuri_5)); }
	inline String_t* get_nsuri_5() const { return ___nsuri_5; }
	inline String_t** get_address_of_nsuri_5() { return &___nsuri_5; }
	inline void set_nsuri_5(String_t* value)
	{
		___nsuri_5 = value;
		Il2CppCodeGenWriteBarrier(&___nsuri_5, value);
	}

	inline static int32_t get_offset_of_nodetype_6() { return static_cast<int32_t>(offsetof(XmlNodeEventArgs_t3585347612, ___nodetype_6)); }
	inline int32_t get_nodetype_6() const { return ___nodetype_6; }
	inline int32_t* get_address_of_nodetype_6() { return &___nodetype_6; }
	inline void set_nodetype_6(int32_t value)
	{
		___nodetype_6 = value;
	}

	inline static int32_t get_offset_of_source_7() { return static_cast<int32_t>(offsetof(XmlNodeEventArgs_t3585347612, ___source_7)); }
	inline Il2CppObject * get_source_7() const { return ___source_7; }
	inline Il2CppObject ** get_address_of_source_7() { return &___source_7; }
	inline void set_source_7(Il2CppObject * value)
	{
		___source_7 = value;
		Il2CppCodeGenWriteBarrier(&___source_7, value);
	}

	inline static int32_t get_offset_of_text_8() { return static_cast<int32_t>(offsetof(XmlNodeEventArgs_t3585347612, ___text_8)); }
	inline String_t* get_text_8() const { return ___text_8; }
	inline String_t** get_address_of_text_8() { return &___text_8; }
	inline void set_text_8(String_t* value)
	{
		___text_8 = value;
		Il2CppCodeGenWriteBarrier(&___text_8, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
