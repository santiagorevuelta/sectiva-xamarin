; ModuleID = 'obj\Debug\130\android\marshal_methods.armeabi-v7a.ll'
source_filename = "obj\Debug\130\android\marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [182 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 48
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 69
	i32 101534019, ; 2: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 58
	i32 120558881, ; 3: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 58
	i32 134690465, ; 4: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x80736a1 => 73
	i32 165246403, ; 5: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 28
	i32 182336117, ; 6: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 60
	i32 209399409, ; 7: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 26
	i32 230216969, ; 8: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 44
	i32 232815796, ; 9: System.Web.Services => 0xde07cb4 => 88
	i32 261689757, ; 10: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 31
	i32 280482487, ; 11: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 42
	i32 318968648, ; 12: Xamarin.AndroidX.Activity.dll => 0x13031348 => 18
	i32 321597661, ; 13: System.Numerics => 0x132b30dd => 13
	i32 342366114, ; 14: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 45
	i32 347068432, ; 15: SQLitePCLRaw.lib.e_sqlite3.android.dll => 0x14afd810 => 7
	i32 385762202, ; 16: System.Memory.dll => 0x16fe439a => 12
	i32 441335492, ; 17: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 30
	i32 442521989, ; 18: Xamarin.Essentials => 0x1a605985 => 67
	i32 450948140, ; 19: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 41
	i32 465846621, ; 20: mscorlib => 0x1bc4415d => 3
	i32 469710990, ; 21: System.dll => 0x1bff388e => 11
	i32 476646585, ; 22: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 42
	i32 486930444, ; 23: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 52
	i32 526420162, ; 24: System.Transactions.dll => 0x1f6088c2 => 81
	i32 527452488, ; 25: Xamarin.Kotlin.StdLib.Jdk7 => 0x1f704948 => 73
	i32 605376203, ; 26: System.IO.Compression.FileSystem => 0x24154ecb => 84
	i32 627609679, ; 27: Xamarin.AndroidX.CustomView => 0x2568904f => 36
	i32 639843206, ; 28: Xamarin.AndroidX.Emoji2.ViewsHelper.dll => 0x26233b86 => 40
	i32 663517072, ; 29: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 65
	i32 666292255, ; 30: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 23
	i32 690569205, ; 31: System.Xml.Linq.dll => 0x29293ff5 => 89
	i32 691348768, ; 32: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 75
	i32 700284507, ; 33: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 70
	i32 720511267, ; 34: Xamarin.Kotlin.StdLib.Jdk8 => 0x2af22123 => 74
	i32 748832960, ; 35: SQLitePCLRaw.batteries_v2 => 0x2ca248c0 => 5
	i32 775507847, ; 36: System.IO.Compression => 0x2e394f87 => 83
	i32 809851609, ; 37: System.Drawing.Common.dll => 0x30455ad9 => 78
	i32 843511501, ; 38: Xamarin.AndroidX.Print => 0x3246f6cd => 54
	i32 928116545, ; 39: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 69
	i32 956575887, ; 40: Xamarin.Kotlin.StdLib.Jdk8.dll => 0x3904308f => 74
	i32 967690846, ; 41: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 45
	i32 1012816738, ; 42: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 57
	i32 1035644815, ; 43: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 22
	i32 1052210849, ; 44: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 49
	i32 1084122840, ; 45: Xamarin.Kotlin.StdLib => 0x409e66d8 => 72
	i32 1098259244, ; 46: System => 0x41761b2c => 11
	i32 1175144683, ; 47: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 63
	i32 1192422187, ; 48: SectivaParking.dll => 0x4712eb2b => 0
	i32 1204270330, ; 49: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 23
	i32 1264511973, ; 50: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0x4b5eebe5 => 59
	i32 1267360935, ; 51: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 64
	i32 1275534314, ; 52: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 75
	i32 1292207520, ; 53: SQLitePCLRaw.core.dll => 0x4d0585a0 => 6
	i32 1293217323, ; 54: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 38
	i32 1365406463, ; 55: System.ServiceModel.Internals.dll => 0x516272ff => 87
	i32 1376866003, ; 56: Xamarin.AndroidX.SavedState => 0x52114ed3 => 57
	i32 1406073936, ; 57: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 32
	i32 1411638395, ; 58: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 15
	i32 1462112819, ; 59: System.IO.Compression.dll => 0x57261233 => 83
	i32 1469204771, ; 60: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 21
	i32 1582372066, ; 61: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 37
	i32 1592978981, ; 62: System.Runtime.Serialization.dll => 0x5ef2ee25 => 86
	i32 1622152042, ; 63: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 51
	i32 1635184631, ; 64: Xamarin.AndroidX.Emoji2.ViewsHelper => 0x6176eff7 => 40
	i32 1636350590, ; 65: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 35
	i32 1639515021, ; 66: System.Net.Http.dll => 0x61b9038d => 77
	i32 1657153582, ; 67: System.Runtime => 0x62c6282e => 16
	i32 1658241508, ; 68: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 61
	i32 1658251792, ; 69: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 68
	i32 1670060433, ; 70: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 31
	i32 1698840827, ; 71: Xamarin.Kotlin.StdLib.Common => 0x654240fb => 71
	i32 1711441057, ; 72: SQLitePCLRaw.lib.e_sqlite3.android => 0x660284a1 => 7
	i32 1729485958, ; 73: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 27
	i32 1766324549, ; 74: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 60
	i32 1776026572, ; 75: System.Core.dll => 0x69dc03cc => 10
	i32 1788241197, ; 76: Xamarin.AndroidX.Fragment => 0x6a96652d => 41
	i32 1808609942, ; 77: Xamarin.AndroidX.Loader => 0x6bcd3296 => 51
	i32 1813058853, ; 78: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 72
	i32 1813201214, ; 79: Xamarin.Google.Android.Material => 0x6c13413e => 68
	i32 1867746548, ; 80: Xamarin.Essentials.dll => 0x6f538cf4 => 67
	i32 1885316902, ; 81: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 24
	i32 1919157823, ; 82: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 53
	i32 1983156543, ; 83: Xamarin.Kotlin.StdLib.Common.dll => 0x7634913f => 71
	i32 2011961780, ; 84: System.Buffers.dll => 0x77ec19b4 => 9
	i32 2019465201, ; 85: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 49
	i32 2055257422, ; 86: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 46
	i32 2079903147, ; 87: System.Runtime.dll => 0x7bf8cdab => 16
	i32 2090596640, ; 88: System.Numerics.Vectors => 0x7c9bf920 => 14
	i32 2097448633, ; 89: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 43
	i32 2103459038, ; 90: SQLitePCLRaw.provider.e_sqlite3.dll => 0x7d603cde => 8
	i32 2201107256, ; 91: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 76
	i32 2201231467, ; 92: System.Net.Http => 0x8334206b => 77
	i32 2217644978, ; 93: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 63
	i32 2244775296, ; 94: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 52
	i32 2256548716, ; 95: Xamarin.AndroidX.MultiDex => 0x8680336c => 53
	i32 2279755925, ; 96: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 55
	i32 2315684594, ; 97: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 19
	i32 2403452196, ; 98: Xamarin.AndroidX.Emoji2.dll => 0x8f41c524 => 39
	i32 2465273461, ; 99: SQLitePCLRaw.batteries_v2.dll => 0x92f11675 => 5
	i32 2465532216, ; 100: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 30
	i32 2471841756, ; 101: netstandard.dll => 0x93554fdc => 79
	i32 2475788418, ; 102: Java.Interop.dll => 0x93918882 => 1
	i32 2501346920, ; 103: System.Data.DataSetExtensions => 0x95178668 => 82
	i32 2505896520, ; 104: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 48
	i32 2581819634, ; 105: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 64
	i32 2605712449, ; 106: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 76
	i32 2620871830, ; 107: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 35
	i32 2701096212, ; 108: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 61
	i32 2732626843, ; 109: Xamarin.AndroidX.Activity => 0xa2e0939b => 18
	i32 2737747696, ; 110: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 21
	i32 2770495804, ; 111: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 70
	i32 2778768386, ; 112: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 66
	i32 2779977773, ; 113: Xamarin.AndroidX.ResourceInspection.Annotation.dll => 0xa5b3182d => 56
	i32 2806888184, ; 114: SectivaParking => 0xa74db6f8 => 0
	i32 2810250172, ; 115: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 32
	i32 2819470561, ; 116: System.Xml.dll => 0xa80db4e1 => 17
	i32 2821294376, ; 117: Xamarin.AndroidX.ResourceInspection.Annotation => 0xa8298928 => 56
	i32 2853208004, ; 118: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 66
	i32 2855708567, ; 119: Xamarin.AndroidX.Transition => 0xaa36a797 => 62
	i32 2903344695, ; 120: System.ComponentModel.Composition => 0xad0d8637 => 85
	i32 2905242038, ; 121: mscorlib.dll => 0xad2a79b6 => 3
	i32 2919462931, ; 122: System.Numerics.Vectors.dll => 0xae037813 => 14
	i32 2921128767, ; 123: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 20
	i32 2978675010, ; 124: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 38
	i32 2996846495, ; 125: Xamarin.AndroidX.Lifecycle.Process.dll => 0xb2a03f9f => 47
	i32 3016983068, ; 126: Xamarin.AndroidX.Startup.StartupRuntime => 0xb3d3821c => 59
	i32 3024354802, ; 127: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 44
	i32 3111772706, ; 128: System.Runtime.Serialization => 0xb979e222 => 86
	i32 3204380047, ; 129: System.Data.dll => 0xbefef58f => 80
	i32 3211777861, ; 130: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 37
	i32 3247949154, ; 131: Mono.Security => 0xc197c562 => 90
	i32 3258312781, ; 132: Xamarin.AndroidX.CardView => 0xc235e84d => 27
	i32 3267021929, ; 133: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 25
	i32 3286872994, ; 134: SQLite-net.dll => 0xc3e9b3a2 => 4
	i32 3317135071, ; 135: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 36
	i32 3317144872, ; 136: System.Data => 0xc5b79d28 => 80
	i32 3340431453, ; 137: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 24
	i32 3353484488, ; 138: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 43
	i32 3360279109, ; 139: SQLitePCLRaw.core => 0xc849ca45 => 6
	i32 3362522851, ; 140: Xamarin.AndroidX.Core => 0xc86c06e3 => 34
	i32 3366347497, ; 141: Java.Interop => 0xc8a662e9 => 1
	i32 3374999561, ; 142: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 55
	i32 3395150330, ; 143: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 15
	i32 3404865022, ; 144: System.ServiceModel.Internals => 0xcaf21dfe => 87
	i32 3429136800, ; 145: System.Xml => 0xcc6479a0 => 17
	i32 3430777524, ; 146: netstandard => 0xcc7d82b4 => 79
	i32 3476120550, ; 147: Mono.Android => 0xcf3163e6 => 2
	i32 3486566296, ; 148: System.Transactions => 0xcfd0c798 => 81
	i32 3493954962, ; 149: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 29
	i32 3501239056, ; 150: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 25
	i32 3509114376, ; 151: System.Xml.Linq => 0xd128d608 => 89
	i32 3567349600, ; 152: System.ComponentModel.Composition.dll => 0xd4a16f60 => 85
	i32 3627220390, ; 153: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 54
	i32 3633644679, ; 154: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 20
	i32 3641597786, ; 155: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 46
	i32 3672681054, ; 156: Mono.Android.dll => 0xdae8aa5e => 2
	i32 3676310014, ; 157: System.Web.Services.dll => 0xdb2009fe => 88
	i32 3682565725, ; 158: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 26
	i32 3684561358, ; 159: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 29
	i32 3689375977, ; 160: System.Drawing.Common => 0xdbe768e9 => 78
	i32 3706696989, ; 161: Xamarin.AndroidX.Core.Core.Ktx.dll => 0xdcefb51d => 33
	i32 3718780102, ; 162: Xamarin.AndroidX.Annotation => 0xdda814c6 => 19
	i32 3754567612, ; 163: SQLitePCLRaw.provider.e_sqlite3 => 0xdfca27bc => 8
	i32 3786282454, ; 164: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 28
	i32 3829621856, ; 165: System.Numerics.dll => 0xe4436460 => 13
	i32 3876362041, ; 166: SQLite-net => 0xe70c9739 => 4
	i32 3885922214, ; 167: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 62
	i32 3896760992, ; 168: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 34
	i32 3920810846, ; 169: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 84
	i32 3921031405, ; 170: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 65
	i32 3945713374, ; 171: System.Data.DataSetExtensions.dll => 0xeb2ecede => 82
	i32 3955647286, ; 172: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 22
	i32 3959773229, ; 173: Xamarin.AndroidX.Lifecycle.Process => 0xec05582d => 47
	i32 4025784931, ; 174: System.Memory => 0xeff49a63 => 12
	i32 4101593132, ; 175: Xamarin.AndroidX.Emoji2 => 0xf479582c => 39
	i32 4105002889, ; 176: Mono.Security.dll => 0xf4ad5f89 => 90
	i32 4151237749, ; 177: System.Core => 0xf76edc75 => 10
	i32 4182413190, ; 178: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 50
	i32 4256097574, ; 179: Xamarin.AndroidX.Core.Core.Ktx => 0xfdaee526 => 33
	i32 4260525087, ; 180: System.Buffers => 0xfdf2741f => 9
	i32 4292120959 ; 181: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 50
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [182 x i32] [
	i32 48, i32 69, i32 58, i32 58, i32 73, i32 28, i32 60, i32 26, ; 0..7
	i32 44, i32 88, i32 31, i32 42, i32 18, i32 13, i32 45, i32 7, ; 8..15
	i32 12, i32 30, i32 67, i32 41, i32 3, i32 11, i32 42, i32 52, ; 16..23
	i32 81, i32 73, i32 84, i32 36, i32 40, i32 65, i32 23, i32 89, ; 24..31
	i32 75, i32 70, i32 74, i32 5, i32 83, i32 78, i32 54, i32 69, ; 32..39
	i32 74, i32 45, i32 57, i32 22, i32 49, i32 72, i32 11, i32 63, ; 40..47
	i32 0, i32 23, i32 59, i32 64, i32 75, i32 6, i32 38, i32 87, ; 48..55
	i32 57, i32 32, i32 15, i32 83, i32 21, i32 37, i32 86, i32 51, ; 56..63
	i32 40, i32 35, i32 77, i32 16, i32 61, i32 68, i32 31, i32 71, ; 64..71
	i32 7, i32 27, i32 60, i32 10, i32 41, i32 51, i32 72, i32 68, ; 72..79
	i32 67, i32 24, i32 53, i32 71, i32 9, i32 49, i32 46, i32 16, ; 80..87
	i32 14, i32 43, i32 8, i32 76, i32 77, i32 63, i32 52, i32 53, ; 88..95
	i32 55, i32 19, i32 39, i32 5, i32 30, i32 79, i32 1, i32 82, ; 96..103
	i32 48, i32 64, i32 76, i32 35, i32 61, i32 18, i32 21, i32 70, ; 104..111
	i32 66, i32 56, i32 0, i32 32, i32 17, i32 56, i32 66, i32 62, ; 112..119
	i32 85, i32 3, i32 14, i32 20, i32 38, i32 47, i32 59, i32 44, ; 120..127
	i32 86, i32 80, i32 37, i32 90, i32 27, i32 25, i32 4, i32 36, ; 128..135
	i32 80, i32 24, i32 43, i32 6, i32 34, i32 1, i32 55, i32 15, ; 136..143
	i32 87, i32 17, i32 79, i32 2, i32 81, i32 29, i32 25, i32 89, ; 144..151
	i32 85, i32 54, i32 20, i32 46, i32 2, i32 88, i32 26, i32 29, ; 152..159
	i32 78, i32 33, i32 19, i32 8, i32 28, i32 13, i32 4, i32 62, ; 160..167
	i32 34, i32 84, i32 65, i32 82, i32 22, i32 47, i32 12, i32 39, ; 168..175
	i32 90, i32 10, i32 50, i32 33, i32 9, i32 50 ; 176..181
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="all" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
!llvm.linker.options = !{}
