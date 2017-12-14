#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object2689449295.h"
#include "mscorlib_System_Guid2533601593.h"

// System.Xml.XmlNameTable
struct XmlNameTable_t1345805268;
// System.Xml.XmlResolver
struct XmlResolver_t2024571559;
// System.Collections.ArrayList
struct ArrayList_t4252133567;
// System.Xml.Schema.XmlSchemaCompilationSettings
struct XmlSchemaCompilationSettings_t2971213394;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Schema.XmlSchemaSet
struct  XmlSchemaSet_t313318308  : public Il2CppObject
{
public:
	// System.Xml.XmlNameTable System.Xml.Schema.XmlSchemaSet::nameTable
	XmlNameTable_t1345805268 * ___nameTable_0;
	// System.Xml.XmlResolver System.Xml.Schema.XmlSchemaSet::xmlResolver
	XmlResolver_t2024571559 * ___xmlResolver_1;
	// System.Collections.ArrayList System.Xml.Schema.XmlSchemaSet::schemas
	ArrayList_t4252133567 * ___schemas_2;
	// System.Xml.Schema.XmlSchemaCompilationSettings System.Xml.Schema.XmlSchemaSet::settings
	XmlSchemaCompilationSettings_t2971213394 * ___settings_3;
	// System.Guid System.Xml.Schema.XmlSchemaSet::CompilationId
	Guid_t  ___CompilationId_4;

public:
	inline static int32_t get_offset_of_nameTable_0() { return static_cast<int32_t>(offsetof(XmlSchemaSet_t313318308, ___nameTable_0)); }
	inline XmlNameTable_t1345805268 * get_nameTable_0() const { return ___nameTable_0; }
	inline XmlNameTable_t1345805268 ** get_address_of_nameTable_0() { return &___nameTable_0; }
	inline void set_nameTable_0(XmlNameTable_t1345805268 * value)
	{
		___nameTable_0 = value;
		Il2CppCodeGenWriteBarrier(&___nameTable_0, value);
	}

	inline static int32_t get_offset_of_xmlResolver_1() { return static_cast<int32_t>(offsetof(XmlSchemaSet_t313318308, ___xmlResolver_1)); }
	inline XmlResolver_t2024571559 * get_xmlResolver_1() const { return ___xmlResolver_1; }
	inline XmlResolver_t2024571559 ** get_address_of_xmlResolver_1() { return &___xmlResolver_1; }
	inline void set_xmlResolver_1(XmlResolver_t2024571559 * value)
	{
		___xmlResolver_1 = value;
		Il2CppCodeGenWriteBarrier(&___xmlResolver_1, value);
	}

	inline static int32_t get_offset_of_schemas_2() { return static_cast<int32_t>(offsetof(XmlSchemaSet_t313318308, ___schemas_2)); }
	inline ArrayList_t4252133567 * get_schemas_2() const { return ___schemas_2; }
	inline ArrayList_t4252133567 ** get_address_of_schemas_2() { return &___schemas_2; }
	inline void set_schemas_2(ArrayList_t4252133567 * value)
	{
		___schemas_2 = value;
		Il2CppCodeGenWriteBarrier(&___schemas_2, value);
	}

	inline static int32_t get_offset_of_settings_3() { return static_cast<int32_t>(offsetof(XmlSchemaSet_t313318308, ___settings_3)); }
	inline XmlSchemaCompilationSettings_t2971213394 * get_settings_3() const { return ___settings_3; }
	inline XmlSchemaCompilationSettings_t2971213394 ** get_address_of_settings_3() { return &___settings_3; }
	inline void set_settings_3(XmlSchemaCompilationSettings_t2971213394 * value)
	{
		___settings_3 = value;
		Il2CppCodeGenWriteBarrier(&___settings_3, value);
	}

	inline static int32_t get_offset_of_CompilationId_4() { return static_cast<int32_t>(offsetof(XmlSchemaSet_t313318308, ___CompilationId_4)); }
	inline Guid_t  get_CompilationId_4() const { return ___CompilationId_4; }
	inline Guid_t * get_address_of_CompilationId_4() { return &___CompilationId_4; }
	inline void set_CompilationId_4(Guid_t  value)
	{
		___CompilationId_4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
