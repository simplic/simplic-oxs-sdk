/*
 * Simplic.OxS.ERP
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Simplic.OxS.SDK.OpenAPIDateConverter;

using Simplic.OxS.SDK;

namespace Simplic.OxS.SDK.ERP
{
    /// <summary>
    /// Defines CurrencyCode
    /// </summary>
    public enum CurrencyCode
    {
        /// <summary>
        /// Enum NUMBER_0 for value: 0
        /// </summary>
        NUMBER_0 = 0,

        /// <summary>
        /// Enum NUMBER_4 for value: 4
        /// </summary>
        NUMBER_4 = 4,

        /// <summary>
        /// Enum NUMBER_8 for value: 8
        /// </summary>
        NUMBER_8 = 8,

        /// <summary>
        /// Enum NUMBER_12 for value: 12
        /// </summary>
        NUMBER_12 = 12,

        /// <summary>
        /// Enum NUMBER_20 for value: 20
        /// </summary>
        NUMBER_20 = 20,

        /// <summary>
        /// Enum NUMBER_24 for value: 24
        /// </summary>
        NUMBER_24 = 24,

        /// <summary>
        /// Enum NUMBER_31 for value: 31
        /// </summary>
        NUMBER_31 = 31,

        /// <summary>
        /// Enum NUMBER_32 for value: 32
        /// </summary>
        NUMBER_32 = 32,

        /// <summary>
        /// Enum NUMBER_36 for value: 36
        /// </summary>
        NUMBER_36 = 36,

        /// <summary>
        /// Enum NUMBER_40 for value: 40
        /// </summary>
        NUMBER_40 = 40,

        /// <summary>
        /// Enum NUMBER_44 for value: 44
        /// </summary>
        NUMBER_44 = 44,

        /// <summary>
        /// Enum NUMBER_48 for value: 48
        /// </summary>
        NUMBER_48 = 48,

        /// <summary>
        /// Enum NUMBER_50 for value: 50
        /// </summary>
        NUMBER_50 = 50,

        /// <summary>
        /// Enum NUMBER_51 for value: 51
        /// </summary>
        NUMBER_51 = 51,

        /// <summary>
        /// Enum NUMBER_52 for value: 52
        /// </summary>
        NUMBER_52 = 52,

        /// <summary>
        /// Enum NUMBER_56 for value: 56
        /// </summary>
        NUMBER_56 = 56,

        /// <summary>
        /// Enum NUMBER_60 for value: 60
        /// </summary>
        NUMBER_60 = 60,

        /// <summary>
        /// Enum NUMBER_64 for value: 64
        /// </summary>
        NUMBER_64 = 64,

        /// <summary>
        /// Enum NUMBER_68 for value: 68
        /// </summary>
        NUMBER_68 = 68,

        /// <summary>
        /// Enum NUMBER_70 for value: 70
        /// </summary>
        NUMBER_70 = 70,

        /// <summary>
        /// Enum NUMBER_72 for value: 72
        /// </summary>
        NUMBER_72 = 72,

        /// <summary>
        /// Enum NUMBER_76 for value: 76
        /// </summary>
        NUMBER_76 = 76,

        /// <summary>
        /// Enum NUMBER_84 for value: 84
        /// </summary>
        NUMBER_84 = 84,

        /// <summary>
        /// Enum NUMBER_90 for value: 90
        /// </summary>
        NUMBER_90 = 90,

        /// <summary>
        /// Enum NUMBER_96 for value: 96
        /// </summary>
        NUMBER_96 = 96,

        /// <summary>
        /// Enum NUMBER_100 for value: 100
        /// </summary>
        NUMBER_100 = 100,

        /// <summary>
        /// Enum NUMBER_104 for value: 104
        /// </summary>
        NUMBER_104 = 104,

        /// <summary>
        /// Enum NUMBER_108 for value: 108
        /// </summary>
        NUMBER_108 = 108,

        /// <summary>
        /// Enum NUMBER_112 for value: 112
        /// </summary>
        NUMBER_112 = 112,

        /// <summary>
        /// Enum NUMBER_116 for value: 116
        /// </summary>
        NUMBER_116 = 116,

        /// <summary>
        /// Enum NUMBER_124 for value: 124
        /// </summary>
        NUMBER_124 = 124,

        /// <summary>
        /// Enum NUMBER_132 for value: 132
        /// </summary>
        NUMBER_132 = 132,

        /// <summary>
        /// Enum NUMBER_136 for value: 136
        /// </summary>
        NUMBER_136 = 136,

        /// <summary>
        /// Enum NUMBER_144 for value: 144
        /// </summary>
        NUMBER_144 = 144,

        /// <summary>
        /// Enum NUMBER_152 for value: 152
        /// </summary>
        NUMBER_152 = 152,

        /// <summary>
        /// Enum NUMBER_156 for value: 156
        /// </summary>
        NUMBER_156 = 156,

        /// <summary>
        /// Enum NUMBER_170 for value: 170
        /// </summary>
        NUMBER_170 = 170,

        /// <summary>
        /// Enum NUMBER_174 for value: 174
        /// </summary>
        NUMBER_174 = 174,

        /// <summary>
        /// Enum NUMBER_180 for value: 180
        /// </summary>
        NUMBER_180 = 180,

        /// <summary>
        /// Enum NUMBER_188 for value: 188
        /// </summary>
        NUMBER_188 = 188,

        /// <summary>
        /// Enum NUMBER_191 for value: 191
        /// </summary>
        NUMBER_191 = 191,

        /// <summary>
        /// Enum NUMBER_192 for value: 192
        /// </summary>
        NUMBER_192 = 192,

        /// <summary>
        /// Enum NUMBER_196 for value: 196
        /// </summary>
        NUMBER_196 = 196,

        /// <summary>
        /// Enum NUMBER_200 for value: 200
        /// </summary>
        NUMBER_200 = 200,

        /// <summary>
        /// Enum NUMBER_203 for value: 203
        /// </summary>
        NUMBER_203 = 203,

        /// <summary>
        /// Enum NUMBER_208 for value: 208
        /// </summary>
        NUMBER_208 = 208,

        /// <summary>
        /// Enum NUMBER_214 for value: 214
        /// </summary>
        NUMBER_214 = 214,

        /// <summary>
        /// Enum NUMBER_218 for value: 218
        /// </summary>
        NUMBER_218 = 218,

        /// <summary>
        /// Enum NUMBER_222 for value: 222
        /// </summary>
        NUMBER_222 = 222,

        /// <summary>
        /// Enum NUMBER_226 for value: 226
        /// </summary>
        NUMBER_226 = 226,

        /// <summary>
        /// Enum NUMBER_230 for value: 230
        /// </summary>
        NUMBER_230 = 230,

        /// <summary>
        /// Enum NUMBER_232 for value: 232
        /// </summary>
        NUMBER_232 = 232,

        /// <summary>
        /// Enum NUMBER_233 for value: 233
        /// </summary>
        NUMBER_233 = 233,

        /// <summary>
        /// Enum NUMBER_238 for value: 238
        /// </summary>
        NUMBER_238 = 238,

        /// <summary>
        /// Enum NUMBER_242 for value: 242
        /// </summary>
        NUMBER_242 = 242,

        /// <summary>
        /// Enum NUMBER_246 for value: 246
        /// </summary>
        NUMBER_246 = 246,

        /// <summary>
        /// Enum NUMBER_250 for value: 250
        /// </summary>
        NUMBER_250 = 250,

        /// <summary>
        /// Enum NUMBER_262 for value: 262
        /// </summary>
        NUMBER_262 = 262,

        /// <summary>
        /// Enum NUMBER_268 for value: 268
        /// </summary>
        NUMBER_268 = 268,

        /// <summary>
        /// Enum NUMBER_270 for value: 270
        /// </summary>
        NUMBER_270 = 270,

        /// <summary>
        /// Enum NUMBER_276 for value: 276
        /// </summary>
        NUMBER_276 = 276,

        /// <summary>
        /// Enum NUMBER_278 for value: 278
        /// </summary>
        NUMBER_278 = 278,

        /// <summary>
        /// Enum NUMBER_288 for value: 288
        /// </summary>
        NUMBER_288 = 288,

        /// <summary>
        /// Enum NUMBER_292 for value: 292
        /// </summary>
        NUMBER_292 = 292,

        /// <summary>
        /// Enum NUMBER_300 for value: 300
        /// </summary>
        NUMBER_300 = 300,

        /// <summary>
        /// Enum NUMBER_320 for value: 320
        /// </summary>
        NUMBER_320 = 320,

        /// <summary>
        /// Enum NUMBER_324 for value: 324
        /// </summary>
        NUMBER_324 = 324,

        /// <summary>
        /// Enum NUMBER_328 for value: 328
        /// </summary>
        NUMBER_328 = 328,

        /// <summary>
        /// Enum NUMBER_332 for value: 332
        /// </summary>
        NUMBER_332 = 332,

        /// <summary>
        /// Enum NUMBER_340 for value: 340
        /// </summary>
        NUMBER_340 = 340,

        /// <summary>
        /// Enum NUMBER_344 for value: 344
        /// </summary>
        NUMBER_344 = 344,

        /// <summary>
        /// Enum NUMBER_348 for value: 348
        /// </summary>
        NUMBER_348 = 348,

        /// <summary>
        /// Enum NUMBER_352 for value: 352
        /// </summary>
        NUMBER_352 = 352,

        /// <summary>
        /// Enum NUMBER_356 for value: 356
        /// </summary>
        NUMBER_356 = 356,

        /// <summary>
        /// Enum NUMBER_360 for value: 360
        /// </summary>
        NUMBER_360 = 360,

        /// <summary>
        /// Enum NUMBER_364 for value: 364
        /// </summary>
        NUMBER_364 = 364,

        /// <summary>
        /// Enum NUMBER_368 for value: 368
        /// </summary>
        NUMBER_368 = 368,

        /// <summary>
        /// Enum NUMBER_372 for value: 372
        /// </summary>
        NUMBER_372 = 372,

        /// <summary>
        /// Enum NUMBER_376 for value: 376
        /// </summary>
        NUMBER_376 = 376,

        /// <summary>
        /// Enum NUMBER_380 for value: 380
        /// </summary>
        NUMBER_380 = 380,

        /// <summary>
        /// Enum NUMBER_388 for value: 388
        /// </summary>
        NUMBER_388 = 388,

        /// <summary>
        /// Enum NUMBER_392 for value: 392
        /// </summary>
        NUMBER_392 = 392,

        /// <summary>
        /// Enum NUMBER_398 for value: 398
        /// </summary>
        NUMBER_398 = 398,

        /// <summary>
        /// Enum NUMBER_400 for value: 400
        /// </summary>
        NUMBER_400 = 400,

        /// <summary>
        /// Enum NUMBER_404 for value: 404
        /// </summary>
        NUMBER_404 = 404,

        /// <summary>
        /// Enum NUMBER_408 for value: 408
        /// </summary>
        NUMBER_408 = 408,

        /// <summary>
        /// Enum NUMBER_410 for value: 410
        /// </summary>
        NUMBER_410 = 410,

        /// <summary>
        /// Enum NUMBER_414 for value: 414
        /// </summary>
        NUMBER_414 = 414,

        /// <summary>
        /// Enum NUMBER_417 for value: 417
        /// </summary>
        NUMBER_417 = 417,

        /// <summary>
        /// Enum NUMBER_418 for value: 418
        /// </summary>
        NUMBER_418 = 418,

        /// <summary>
        /// Enum NUMBER_422 for value: 422
        /// </summary>
        NUMBER_422 = 422,

        /// <summary>
        /// Enum NUMBER_426 for value: 426
        /// </summary>
        NUMBER_426 = 426,

        /// <summary>
        /// Enum NUMBER_428 for value: 428
        /// </summary>
        NUMBER_428 = 428,

        /// <summary>
        /// Enum NUMBER_430 for value: 430
        /// </summary>
        NUMBER_430 = 430,

        /// <summary>
        /// Enum NUMBER_434 for value: 434
        /// </summary>
        NUMBER_434 = 434,

        /// <summary>
        /// Enum NUMBER_440 for value: 440
        /// </summary>
        NUMBER_440 = 440,

        /// <summary>
        /// Enum NUMBER_442 for value: 442
        /// </summary>
        NUMBER_442 = 442,

        /// <summary>
        /// Enum NUMBER_446 for value: 446
        /// </summary>
        NUMBER_446 = 446,

        /// <summary>
        /// Enum NUMBER_450 for value: 450
        /// </summary>
        NUMBER_450 = 450,

        /// <summary>
        /// Enum NUMBER_454 for value: 454
        /// </summary>
        NUMBER_454 = 454,

        /// <summary>
        /// Enum NUMBER_458 for value: 458
        /// </summary>
        NUMBER_458 = 458,

        /// <summary>
        /// Enum NUMBER_462 for value: 462
        /// </summary>
        NUMBER_462 = 462,

        /// <summary>
        /// Enum NUMBER_466 for value: 466
        /// </summary>
        NUMBER_466 = 466,

        /// <summary>
        /// Enum NUMBER_470 for value: 470
        /// </summary>
        NUMBER_470 = 470,

        /// <summary>
        /// Enum NUMBER_478 for value: 478
        /// </summary>
        NUMBER_478 = 478,

        /// <summary>
        /// Enum NUMBER_480 for value: 480
        /// </summary>
        NUMBER_480 = 480,

        /// <summary>
        /// Enum NUMBER_484 for value: 484
        /// </summary>
        NUMBER_484 = 484,

        /// <summary>
        /// Enum NUMBER_496 for value: 496
        /// </summary>
        NUMBER_496 = 496,

        /// <summary>
        /// Enum NUMBER_498 for value: 498
        /// </summary>
        NUMBER_498 = 498,

        /// <summary>
        /// Enum NUMBER_504 for value: 504
        /// </summary>
        NUMBER_504 = 504,

        /// <summary>
        /// Enum NUMBER_508 for value: 508
        /// </summary>
        NUMBER_508 = 508,

        /// <summary>
        /// Enum NUMBER_512 for value: 512
        /// </summary>
        NUMBER_512 = 512,

        /// <summary>
        /// Enum NUMBER_516 for value: 516
        /// </summary>
        NUMBER_516 = 516,

        /// <summary>
        /// Enum NUMBER_524 for value: 524
        /// </summary>
        NUMBER_524 = 524,

        /// <summary>
        /// Enum NUMBER_528 for value: 528
        /// </summary>
        NUMBER_528 = 528,

        /// <summary>
        /// Enum NUMBER_532 for value: 532
        /// </summary>
        NUMBER_532 = 532,

        /// <summary>
        /// Enum NUMBER_533 for value: 533
        /// </summary>
        NUMBER_533 = 533,

        /// <summary>
        /// Enum NUMBER_548 for value: 548
        /// </summary>
        NUMBER_548 = 548,

        /// <summary>
        /// Enum NUMBER_554 for value: 554
        /// </summary>
        NUMBER_554 = 554,

        /// <summary>
        /// Enum NUMBER_558 for value: 558
        /// </summary>
        NUMBER_558 = 558,

        /// <summary>
        /// Enum NUMBER_566 for value: 566
        /// </summary>
        NUMBER_566 = 566,

        /// <summary>
        /// Enum NUMBER_578 for value: 578
        /// </summary>
        NUMBER_578 = 578,

        /// <summary>
        /// Enum NUMBER_586 for value: 586
        /// </summary>
        NUMBER_586 = 586,

        /// <summary>
        /// Enum NUMBER_590 for value: 590
        /// </summary>
        NUMBER_590 = 590,

        /// <summary>
        /// Enum NUMBER_598 for value: 598
        /// </summary>
        NUMBER_598 = 598,

        /// <summary>
        /// Enum NUMBER_600 for value: 600
        /// </summary>
        NUMBER_600 = 600,

        /// <summary>
        /// Enum NUMBER_604 for value: 604
        /// </summary>
        NUMBER_604 = 604,

        /// <summary>
        /// Enum NUMBER_608 for value: 608
        /// </summary>
        NUMBER_608 = 608,

        /// <summary>
        /// Enum NUMBER_616 for value: 616
        /// </summary>
        NUMBER_616 = 616,

        /// <summary>
        /// Enum NUMBER_620 for value: 620
        /// </summary>
        NUMBER_620 = 620,

        /// <summary>
        /// Enum NUMBER_624 for value: 624
        /// </summary>
        NUMBER_624 = 624,

        /// <summary>
        /// Enum NUMBER_626 for value: 626
        /// </summary>
        NUMBER_626 = 626,

        /// <summary>
        /// Enum NUMBER_634 for value: 634
        /// </summary>
        NUMBER_634 = 634,

        /// <summary>
        /// Enum NUMBER_642 for value: 642
        /// </summary>
        NUMBER_642 = 642,

        /// <summary>
        /// Enum NUMBER_643 for value: 643
        /// </summary>
        NUMBER_643 = 643,

        /// <summary>
        /// Enum NUMBER_646 for value: 646
        /// </summary>
        NUMBER_646 = 646,

        /// <summary>
        /// Enum NUMBER_654 for value: 654
        /// </summary>
        NUMBER_654 = 654,

        /// <summary>
        /// Enum NUMBER_678 for value: 678
        /// </summary>
        NUMBER_678 = 678,

        /// <summary>
        /// Enum NUMBER_682 for value: 682
        /// </summary>
        NUMBER_682 = 682,

        /// <summary>
        /// Enum NUMBER_690 for value: 690
        /// </summary>
        NUMBER_690 = 690,

        /// <summary>
        /// Enum NUMBER_694 for value: 694
        /// </summary>
        NUMBER_694 = 694,

        /// <summary>
        /// Enum NUMBER_702 for value: 702
        /// </summary>
        NUMBER_702 = 702,

        /// <summary>
        /// Enum NUMBER_703 for value: 703
        /// </summary>
        NUMBER_703 = 703,

        /// <summary>
        /// Enum NUMBER_704 for value: 704
        /// </summary>
        NUMBER_704 = 704,

        /// <summary>
        /// Enum NUMBER_705 for value: 705
        /// </summary>
        NUMBER_705 = 705,

        /// <summary>
        /// Enum NUMBER_706 for value: 706
        /// </summary>
        NUMBER_706 = 706,

        /// <summary>
        /// Enum NUMBER_710 for value: 710
        /// </summary>
        NUMBER_710 = 710,

        /// <summary>
        /// Enum NUMBER_716 for value: 716
        /// </summary>
        NUMBER_716 = 716,

        /// <summary>
        /// Enum NUMBER_720 for value: 720
        /// </summary>
        NUMBER_720 = 720,

        /// <summary>
        /// Enum NUMBER_724 for value: 724
        /// </summary>
        NUMBER_724 = 724,

        /// <summary>
        /// Enum NUMBER_728 for value: 728
        /// </summary>
        NUMBER_728 = 728,

        /// <summary>
        /// Enum NUMBER_736 for value: 736
        /// </summary>
        NUMBER_736 = 736,

        /// <summary>
        /// Enum NUMBER_740 for value: 740
        /// </summary>
        NUMBER_740 = 740,

        /// <summary>
        /// Enum NUMBER_748 for value: 748
        /// </summary>
        NUMBER_748 = 748,

        /// <summary>
        /// Enum NUMBER_752 for value: 752
        /// </summary>
        NUMBER_752 = 752,

        /// <summary>
        /// Enum NUMBER_756 for value: 756
        /// </summary>
        NUMBER_756 = 756,

        /// <summary>
        /// Enum NUMBER_760 for value: 760
        /// </summary>
        NUMBER_760 = 760,

        /// <summary>
        /// Enum NUMBER_762 for value: 762
        /// </summary>
        NUMBER_762 = 762,

        /// <summary>
        /// Enum NUMBER_764 for value: 764
        /// </summary>
        NUMBER_764 = 764,

        /// <summary>
        /// Enum NUMBER_776 for value: 776
        /// </summary>
        NUMBER_776 = 776,

        /// <summary>
        /// Enum NUMBER_780 for value: 780
        /// </summary>
        NUMBER_780 = 780,

        /// <summary>
        /// Enum NUMBER_784 for value: 784
        /// </summary>
        NUMBER_784 = 784,

        /// <summary>
        /// Enum NUMBER_788 for value: 788
        /// </summary>
        NUMBER_788 = 788,

        /// <summary>
        /// Enum NUMBER_792 for value: 792
        /// </summary>
        NUMBER_792 = 792,

        /// <summary>
        /// Enum NUMBER_795 for value: 795
        /// </summary>
        NUMBER_795 = 795,

        /// <summary>
        /// Enum NUMBER_800 for value: 800
        /// </summary>
        NUMBER_800 = 800,

        /// <summary>
        /// Enum NUMBER_804 for value: 804
        /// </summary>
        NUMBER_804 = 804,

        /// <summary>
        /// Enum NUMBER_807 for value: 807
        /// </summary>
        NUMBER_807 = 807,

        /// <summary>
        /// Enum NUMBER_810 for value: 810
        /// </summary>
        NUMBER_810 = 810,

        /// <summary>
        /// Enum NUMBER_818 for value: 818
        /// </summary>
        NUMBER_818 = 818,

        /// <summary>
        /// Enum NUMBER_826 for value: 826
        /// </summary>
        NUMBER_826 = 826,

        /// <summary>
        /// Enum NUMBER_834 for value: 834
        /// </summary>
        NUMBER_834 = 834,

        /// <summary>
        /// Enum NUMBER_840 for value: 840
        /// </summary>
        NUMBER_840 = 840,

        /// <summary>
        /// Enum NUMBER_858 for value: 858
        /// </summary>
        NUMBER_858 = 858,

        /// <summary>
        /// Enum NUMBER_860 for value: 860
        /// </summary>
        NUMBER_860 = 860,

        /// <summary>
        /// Enum NUMBER_862 for value: 862
        /// </summary>
        NUMBER_862 = 862,

        /// <summary>
        /// Enum NUMBER_882 for value: 882
        /// </summary>
        NUMBER_882 = 882,

        /// <summary>
        /// Enum NUMBER_886 for value: 886
        /// </summary>
        NUMBER_886 = 886,

        /// <summary>
        /// Enum NUMBER_890 for value: 890
        /// </summary>
        NUMBER_890 = 890,

        /// <summary>
        /// Enum NUMBER_891 for value: 891
        /// </summary>
        NUMBER_891 = 891,

        /// <summary>
        /// Enum NUMBER_894 for value: 894
        /// </summary>
        NUMBER_894 = 894,

        /// <summary>
        /// Enum NUMBER_901 for value: 901
        /// </summary>
        NUMBER_901 = 901,

        /// <summary>
        /// Enum NUMBER_927 for value: 927
        /// </summary>
        NUMBER_927 = 927,

        /// <summary>
        /// Enum NUMBER_928 for value: 928
        /// </summary>
        NUMBER_928 = 928,

        /// <summary>
        /// Enum NUMBER_929 for value: 929
        /// </summary>
        NUMBER_929 = 929,

        /// <summary>
        /// Enum NUMBER_930 for value: 930
        /// </summary>
        NUMBER_930 = 930,

        /// <summary>
        /// Enum NUMBER_931 for value: 931
        /// </summary>
        NUMBER_931 = 931,

        /// <summary>
        /// Enum NUMBER_932 for value: 932
        /// </summary>
        NUMBER_932 = 932,

        /// <summary>
        /// Enum NUMBER_933 for value: 933
        /// </summary>
        NUMBER_933 = 933,

        /// <summary>
        /// Enum NUMBER_934 for value: 934
        /// </summary>
        NUMBER_934 = 934,

        /// <summary>
        /// Enum NUMBER_935 for value: 935
        /// </summary>
        NUMBER_935 = 935,

        /// <summary>
        /// Enum NUMBER_936 for value: 936
        /// </summary>
        NUMBER_936 = 936,

        /// <summary>
        /// Enum NUMBER_937 for value: 937
        /// </summary>
        NUMBER_937 = 937,

        /// <summary>
        /// Enum NUMBER_938 for value: 938
        /// </summary>
        NUMBER_938 = 938,

        /// <summary>
        /// Enum NUMBER_939 for value: 939
        /// </summary>
        NUMBER_939 = 939,

        /// <summary>
        /// Enum NUMBER_940 for value: 940
        /// </summary>
        NUMBER_940 = 940,

        /// <summary>
        /// Enum NUMBER_941 for value: 941
        /// </summary>
        NUMBER_941 = 941,

        /// <summary>
        /// Enum NUMBER_942 for value: 942
        /// </summary>
        NUMBER_942 = 942,

        /// <summary>
        /// Enum NUMBER_943 for value: 943
        /// </summary>
        NUMBER_943 = 943,

        /// <summary>
        /// Enum NUMBER_944 for value: 944
        /// </summary>
        NUMBER_944 = 944,

        /// <summary>
        /// Enum NUMBER_945 for value: 945
        /// </summary>
        NUMBER_945 = 945,

        /// <summary>
        /// Enum NUMBER_946 for value: 946
        /// </summary>
        NUMBER_946 = 946,

        /// <summary>
        /// Enum NUMBER_947 for value: 947
        /// </summary>
        NUMBER_947 = 947,

        /// <summary>
        /// Enum NUMBER_948 for value: 948
        /// </summary>
        NUMBER_948 = 948,

        /// <summary>
        /// Enum NUMBER_949 for value: 949
        /// </summary>
        NUMBER_949 = 949,

        /// <summary>
        /// Enum NUMBER_950 for value: 950
        /// </summary>
        NUMBER_950 = 950,

        /// <summary>
        /// Enum NUMBER_951 for value: 951
        /// </summary>
        NUMBER_951 = 951,

        /// <summary>
        /// Enum NUMBER_952 for value: 952
        /// </summary>
        NUMBER_952 = 952,

        /// <summary>
        /// Enum NUMBER_953 for value: 953
        /// </summary>
        NUMBER_953 = 953,

        /// <summary>
        /// Enum NUMBER_954 for value: 954
        /// </summary>
        NUMBER_954 = 954,

        /// <summary>
        /// Enum NUMBER_955 for value: 955
        /// </summary>
        NUMBER_955 = 955,

        /// <summary>
        /// Enum NUMBER_956 for value: 956
        /// </summary>
        NUMBER_956 = 956,

        /// <summary>
        /// Enum NUMBER_957 for value: 957
        /// </summary>
        NUMBER_957 = 957,

        /// <summary>
        /// Enum NUMBER_958 for value: 958
        /// </summary>
        NUMBER_958 = 958,

        /// <summary>
        /// Enum NUMBER_959 for value: 959
        /// </summary>
        NUMBER_959 = 959,

        /// <summary>
        /// Enum NUMBER_960 for value: 960
        /// </summary>
        NUMBER_960 = 960,

        /// <summary>
        /// Enum NUMBER_961 for value: 961
        /// </summary>
        NUMBER_961 = 961,

        /// <summary>
        /// Enum NUMBER_962 for value: 962
        /// </summary>
        NUMBER_962 = 962,

        /// <summary>
        /// Enum NUMBER_963 for value: 963
        /// </summary>
        NUMBER_963 = 963,

        /// <summary>
        /// Enum NUMBER_964 for value: 964
        /// </summary>
        NUMBER_964 = 964,

        /// <summary>
        /// Enum NUMBER_965 for value: 965
        /// </summary>
        NUMBER_965 = 965,

        /// <summary>
        /// Enum NUMBER_967 for value: 967
        /// </summary>
        NUMBER_967 = 967,

        /// <summary>
        /// Enum NUMBER_968 for value: 968
        /// </summary>
        NUMBER_968 = 968,

        /// <summary>
        /// Enum NUMBER_969 for value: 969
        /// </summary>
        NUMBER_969 = 969,

        /// <summary>
        /// Enum NUMBER_970 for value: 970
        /// </summary>
        NUMBER_970 = 970,

        /// <summary>
        /// Enum NUMBER_971 for value: 971
        /// </summary>
        NUMBER_971 = 971,

        /// <summary>
        /// Enum NUMBER_972 for value: 972
        /// </summary>
        NUMBER_972 = 972,

        /// <summary>
        /// Enum NUMBER_973 for value: 973
        /// </summary>
        NUMBER_973 = 973,

        /// <summary>
        /// Enum NUMBER_974 for value: 974
        /// </summary>
        NUMBER_974 = 974,

        /// <summary>
        /// Enum NUMBER_975 for value: 975
        /// </summary>
        NUMBER_975 = 975,

        /// <summary>
        /// Enum NUMBER_976 for value: 976
        /// </summary>
        NUMBER_976 = 976,

        /// <summary>
        /// Enum NUMBER_977 for value: 977
        /// </summary>
        NUMBER_977 = 977,

        /// <summary>
        /// Enum NUMBER_978 for value: 978
        /// </summary>
        NUMBER_978 = 978,

        /// <summary>
        /// Enum NUMBER_979 for value: 979
        /// </summary>
        NUMBER_979 = 979,

        /// <summary>
        /// Enum NUMBER_980 for value: 980
        /// </summary>
        NUMBER_980 = 980,

        /// <summary>
        /// Enum NUMBER_981 for value: 981
        /// </summary>
        NUMBER_981 = 981,

        /// <summary>
        /// Enum NUMBER_982 for value: 982
        /// </summary>
        NUMBER_982 = 982,

        /// <summary>
        /// Enum NUMBER_983 for value: 983
        /// </summary>
        NUMBER_983 = 983,

        /// <summary>
        /// Enum NUMBER_984 for value: 984
        /// </summary>
        NUMBER_984 = 984,

        /// <summary>
        /// Enum NUMBER_985 for value: 985
        /// </summary>
        NUMBER_985 = 985,

        /// <summary>
        /// Enum NUMBER_986 for value: 986
        /// </summary>
        NUMBER_986 = 986,

        /// <summary>
        /// Enum NUMBER_987 for value: 987
        /// </summary>
        NUMBER_987 = 987,

        /// <summary>
        /// Enum NUMBER_988 for value: 988
        /// </summary>
        NUMBER_988 = 988,

        /// <summary>
        /// Enum NUMBER_989 for value: 989
        /// </summary>
        NUMBER_989 = 989,

        /// <summary>
        /// Enum NUMBER_990 for value: 990
        /// </summary>
        NUMBER_990 = 990,

        /// <summary>
        /// Enum NUMBER_991 for value: 991
        /// </summary>
        NUMBER_991 = 991,

        /// <summary>
        /// Enum NUMBER_992 for value: 992
        /// </summary>
        NUMBER_992 = 992,

        /// <summary>
        /// Enum NUMBER_993 for value: 993
        /// </summary>
        NUMBER_993 = 993,

        /// <summary>
        /// Enum NUMBER_994 for value: 994
        /// </summary>
        NUMBER_994 = 994,

        /// <summary>
        /// Enum NUMBER_995 for value: 995
        /// </summary>
        NUMBER_995 = 995,

        /// <summary>
        /// Enum NUMBER_996 for value: 996
        /// </summary>
        NUMBER_996 = 996,

        /// <summary>
        /// Enum NUMBER_997 for value: 997
        /// </summary>
        NUMBER_997 = 997,

        /// <summary>
        /// Enum NUMBER_998 for value: 998
        /// </summary>
        NUMBER_998 = 998,

        /// <summary>
        /// Enum NUMBER_999 for value: 999
        /// </summary>
        NUMBER_999 = 999
    }

}
