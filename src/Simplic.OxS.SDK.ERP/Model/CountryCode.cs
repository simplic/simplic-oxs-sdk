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
    /// Defines CountryCode
    /// </summary>
    public enum CountryCode
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
        /// Enum NUMBER_10 for value: 10
        /// </summary>
        NUMBER_10 = 10,

        /// <summary>
        /// Enum NUMBER_12 for value: 12
        /// </summary>
        NUMBER_12 = 12,

        /// <summary>
        /// Enum NUMBER_16 for value: 16
        /// </summary>
        NUMBER_16 = 16,

        /// <summary>
        /// Enum NUMBER_20 for value: 20
        /// </summary>
        NUMBER_20 = 20,

        /// <summary>
        /// Enum NUMBER_24 for value: 24
        /// </summary>
        NUMBER_24 = 24,

        /// <summary>
        /// Enum NUMBER_28 for value: 28
        /// </summary>
        NUMBER_28 = 28,

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
        /// Enum NUMBER_74 for value: 74
        /// </summary>
        NUMBER_74 = 74,

        /// <summary>
        /// Enum NUMBER_76 for value: 76
        /// </summary>
        NUMBER_76 = 76,

        /// <summary>
        /// Enum NUMBER_84 for value: 84
        /// </summary>
        NUMBER_84 = 84,

        /// <summary>
        /// Enum NUMBER_86 for value: 86
        /// </summary>
        NUMBER_86 = 86,

        /// <summary>
        /// Enum NUMBER_90 for value: 90
        /// </summary>
        NUMBER_90 = 90,

        /// <summary>
        /// Enum NUMBER_92 for value: 92
        /// </summary>
        NUMBER_92 = 92,

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
        /// Enum NUMBER_120 for value: 120
        /// </summary>
        NUMBER_120 = 120,

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
        /// Enum NUMBER_140 for value: 140
        /// </summary>
        NUMBER_140 = 140,

        /// <summary>
        /// Enum NUMBER_144 for value: 144
        /// </summary>
        NUMBER_144 = 144,

        /// <summary>
        /// Enum NUMBER_148 for value: 148
        /// </summary>
        NUMBER_148 = 148,

        /// <summary>
        /// Enum NUMBER_152 for value: 152
        /// </summary>
        NUMBER_152 = 152,

        /// <summary>
        /// Enum NUMBER_156 for value: 156
        /// </summary>
        NUMBER_156 = 156,

        /// <summary>
        /// Enum NUMBER_158 for value: 158
        /// </summary>
        NUMBER_158 = 158,

        /// <summary>
        /// Enum NUMBER_162 for value: 162
        /// </summary>
        NUMBER_162 = 162,

        /// <summary>
        /// Enum NUMBER_166 for value: 166
        /// </summary>
        NUMBER_166 = 166,

        /// <summary>
        /// Enum NUMBER_170 for value: 170
        /// </summary>
        NUMBER_170 = 170,

        /// <summary>
        /// Enum NUMBER_174 for value: 174
        /// </summary>
        NUMBER_174 = 174,

        /// <summary>
        /// Enum NUMBER_175 for value: 175
        /// </summary>
        NUMBER_175 = 175,

        /// <summary>
        /// Enum NUMBER_178 for value: 178
        /// </summary>
        NUMBER_178 = 178,

        /// <summary>
        /// Enum NUMBER_180 for value: 180
        /// </summary>
        NUMBER_180 = 180,

        /// <summary>
        /// Enum NUMBER_184 for value: 184
        /// </summary>
        NUMBER_184 = 184,

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
        /// Enum NUMBER_203 for value: 203
        /// </summary>
        NUMBER_203 = 203,

        /// <summary>
        /// Enum NUMBER_204 for value: 204
        /// </summary>
        NUMBER_204 = 204,

        /// <summary>
        /// Enum NUMBER_208 for value: 208
        /// </summary>
        NUMBER_208 = 208,

        /// <summary>
        /// Enum NUMBER_212 for value: 212
        /// </summary>
        NUMBER_212 = 212,

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
        /// Enum NUMBER_231 for value: 231
        /// </summary>
        NUMBER_231 = 231,

        /// <summary>
        /// Enum NUMBER_232 for value: 232
        /// </summary>
        NUMBER_232 = 232,

        /// <summary>
        /// Enum NUMBER_233 for value: 233
        /// </summary>
        NUMBER_233 = 233,

        /// <summary>
        /// Enum NUMBER_234 for value: 234
        /// </summary>
        NUMBER_234 = 234,

        /// <summary>
        /// Enum NUMBER_238 for value: 238
        /// </summary>
        NUMBER_238 = 238,

        /// <summary>
        /// Enum NUMBER_239 for value: 239
        /// </summary>
        NUMBER_239 = 239,

        /// <summary>
        /// Enum NUMBER_242 for value: 242
        /// </summary>
        NUMBER_242 = 242,

        /// <summary>
        /// Enum NUMBER_246 for value: 246
        /// </summary>
        NUMBER_246 = 246,

        /// <summary>
        /// Enum NUMBER_248 for value: 248
        /// </summary>
        NUMBER_248 = 248,

        /// <summary>
        /// Enum NUMBER_250 for value: 250
        /// </summary>
        NUMBER_250 = 250,

        /// <summary>
        /// Enum NUMBER_254 for value: 254
        /// </summary>
        NUMBER_254 = 254,

        /// <summary>
        /// Enum NUMBER_258 for value: 258
        /// </summary>
        NUMBER_258 = 258,

        /// <summary>
        /// Enum NUMBER_260 for value: 260
        /// </summary>
        NUMBER_260 = 260,

        /// <summary>
        /// Enum NUMBER_262 for value: 262
        /// </summary>
        NUMBER_262 = 262,

        /// <summary>
        /// Enum NUMBER_266 for value: 266
        /// </summary>
        NUMBER_266 = 266,

        /// <summary>
        /// Enum NUMBER_268 for value: 268
        /// </summary>
        NUMBER_268 = 268,

        /// <summary>
        /// Enum NUMBER_270 for value: 270
        /// </summary>
        NUMBER_270 = 270,

        /// <summary>
        /// Enum NUMBER_275 for value: 275
        /// </summary>
        NUMBER_275 = 275,

        /// <summary>
        /// Enum NUMBER_276 for value: 276
        /// </summary>
        NUMBER_276 = 276,

        /// <summary>
        /// Enum NUMBER_288 for value: 288
        /// </summary>
        NUMBER_288 = 288,

        /// <summary>
        /// Enum NUMBER_292 for value: 292
        /// </summary>
        NUMBER_292 = 292,

        /// <summary>
        /// Enum NUMBER_296 for value: 296
        /// </summary>
        NUMBER_296 = 296,

        /// <summary>
        /// Enum NUMBER_300 for value: 300
        /// </summary>
        NUMBER_300 = 300,

        /// <summary>
        /// Enum NUMBER_304 for value: 304
        /// </summary>
        NUMBER_304 = 304,

        /// <summary>
        /// Enum NUMBER_308 for value: 308
        /// </summary>
        NUMBER_308 = 308,

        /// <summary>
        /// Enum NUMBER_312 for value: 312
        /// </summary>
        NUMBER_312 = 312,

        /// <summary>
        /// Enum NUMBER_316 for value: 316
        /// </summary>
        NUMBER_316 = 316,

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
        /// Enum NUMBER_334 for value: 334
        /// </summary>
        NUMBER_334 = 334,

        /// <summary>
        /// Enum NUMBER_336 for value: 336
        /// </summary>
        NUMBER_336 = 336,

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
        /// Enum NUMBER_384 for value: 384
        /// </summary>
        NUMBER_384 = 384,

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
        /// Enum NUMBER_438 for value: 438
        /// </summary>
        NUMBER_438 = 438,

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
        /// Enum NUMBER_474 for value: 474
        /// </summary>
        NUMBER_474 = 474,

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
        /// Enum NUMBER_492 for value: 492
        /// </summary>
        NUMBER_492 = 492,

        /// <summary>
        /// Enum NUMBER_496 for value: 496
        /// </summary>
        NUMBER_496 = 496,

        /// <summary>
        /// Enum NUMBER_498 for value: 498
        /// </summary>
        NUMBER_498 = 498,

        /// <summary>
        /// Enum NUMBER_499 for value: 499
        /// </summary>
        NUMBER_499 = 499,

        /// <summary>
        /// Enum NUMBER_500 for value: 500
        /// </summary>
        NUMBER_500 = 500,

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
        /// Enum NUMBER_520 for value: 520
        /// </summary>
        NUMBER_520 = 520,

        /// <summary>
        /// Enum NUMBER_524 for value: 524
        /// </summary>
        NUMBER_524 = 524,

        /// <summary>
        /// Enum NUMBER_528 for value: 528
        /// </summary>
        NUMBER_528 = 528,

        /// <summary>
        /// Enum NUMBER_531 for value: 531
        /// </summary>
        NUMBER_531 = 531,

        /// <summary>
        /// Enum NUMBER_533 for value: 533
        /// </summary>
        NUMBER_533 = 533,

        /// <summary>
        /// Enum NUMBER_534 for value: 534
        /// </summary>
        NUMBER_534 = 534,

        /// <summary>
        /// Enum NUMBER_535 for value: 535
        /// </summary>
        NUMBER_535 = 535,

        /// <summary>
        /// Enum NUMBER_540 for value: 540
        /// </summary>
        NUMBER_540 = 540,

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
        /// Enum NUMBER_562 for value: 562
        /// </summary>
        NUMBER_562 = 562,

        /// <summary>
        /// Enum NUMBER_566 for value: 566
        /// </summary>
        NUMBER_566 = 566,

        /// <summary>
        /// Enum NUMBER_570 for value: 570
        /// </summary>
        NUMBER_570 = 570,

        /// <summary>
        /// Enum NUMBER_574 for value: 574
        /// </summary>
        NUMBER_574 = 574,

        /// <summary>
        /// Enum NUMBER_578 for value: 578
        /// </summary>
        NUMBER_578 = 578,

        /// <summary>
        /// Enum NUMBER_580 for value: 580
        /// </summary>
        NUMBER_580 = 580,

        /// <summary>
        /// Enum NUMBER_581 for value: 581
        /// </summary>
        NUMBER_581 = 581,

        /// <summary>
        /// Enum NUMBER_583 for value: 583
        /// </summary>
        NUMBER_583 = 583,

        /// <summary>
        /// Enum NUMBER_584 for value: 584
        /// </summary>
        NUMBER_584 = 584,

        /// <summary>
        /// Enum NUMBER_585 for value: 585
        /// </summary>
        NUMBER_585 = 585,

        /// <summary>
        /// Enum NUMBER_586 for value: 586
        /// </summary>
        NUMBER_586 = 586,

        /// <summary>
        /// Enum NUMBER_591 for value: 591
        /// </summary>
        NUMBER_591 = 591,

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
        /// Enum NUMBER_612 for value: 612
        /// </summary>
        NUMBER_612 = 612,

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
        /// Enum NUMBER_630 for value: 630
        /// </summary>
        NUMBER_630 = 630,

        /// <summary>
        /// Enum NUMBER_634 for value: 634
        /// </summary>
        NUMBER_634 = 634,

        /// <summary>
        /// Enum NUMBER_638 for value: 638
        /// </summary>
        NUMBER_638 = 638,

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
        /// Enum NUMBER_652 for value: 652
        /// </summary>
        NUMBER_652 = 652,

        /// <summary>
        /// Enum NUMBER_654 for value: 654
        /// </summary>
        NUMBER_654 = 654,

        /// <summary>
        /// Enum NUMBER_659 for value: 659
        /// </summary>
        NUMBER_659 = 659,

        /// <summary>
        /// Enum NUMBER_660 for value: 660
        /// </summary>
        NUMBER_660 = 660,

        /// <summary>
        /// Enum NUMBER_662 for value: 662
        /// </summary>
        NUMBER_662 = 662,

        /// <summary>
        /// Enum NUMBER_663 for value: 663
        /// </summary>
        NUMBER_663 = 663,

        /// <summary>
        /// Enum NUMBER_666 for value: 666
        /// </summary>
        NUMBER_666 = 666,

        /// <summary>
        /// Enum NUMBER_670 for value: 670
        /// </summary>
        NUMBER_670 = 670,

        /// <summary>
        /// Enum NUMBER_674 for value: 674
        /// </summary>
        NUMBER_674 = 674,

        /// <summary>
        /// Enum NUMBER_678 for value: 678
        /// </summary>
        NUMBER_678 = 678,

        /// <summary>
        /// Enum NUMBER_682 for value: 682
        /// </summary>
        NUMBER_682 = 682,

        /// <summary>
        /// Enum NUMBER_686 for value: 686
        /// </summary>
        NUMBER_686 = 686,

        /// <summary>
        /// Enum NUMBER_688 for value: 688
        /// </summary>
        NUMBER_688 = 688,

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
        /// Enum NUMBER_724 for value: 724
        /// </summary>
        NUMBER_724 = 724,

        /// <summary>
        /// Enum NUMBER_728 for value: 728
        /// </summary>
        NUMBER_728 = 728,

        /// <summary>
        /// Enum NUMBER_729 for value: 729
        /// </summary>
        NUMBER_729 = 729,

        /// <summary>
        /// Enum NUMBER_732 for value: 732
        /// </summary>
        NUMBER_732 = 732,

        /// <summary>
        /// Enum NUMBER_740 for value: 740
        /// </summary>
        NUMBER_740 = 740,

        /// <summary>
        /// Enum NUMBER_744 for value: 744
        /// </summary>
        NUMBER_744 = 744,

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
        /// Enum NUMBER_768 for value: 768
        /// </summary>
        NUMBER_768 = 768,

        /// <summary>
        /// Enum NUMBER_772 for value: 772
        /// </summary>
        NUMBER_772 = 772,

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
        /// Enum NUMBER_796 for value: 796
        /// </summary>
        NUMBER_796 = 796,

        /// <summary>
        /// Enum NUMBER_798 for value: 798
        /// </summary>
        NUMBER_798 = 798,

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
        /// Enum NUMBER_818 for value: 818
        /// </summary>
        NUMBER_818 = 818,

        /// <summary>
        /// Enum NUMBER_826 for value: 826
        /// </summary>
        NUMBER_826 = 826,

        /// <summary>
        /// Enum NUMBER_831 for value: 831
        /// </summary>
        NUMBER_831 = 831,

        /// <summary>
        /// Enum NUMBER_832 for value: 832
        /// </summary>
        NUMBER_832 = 832,

        /// <summary>
        /// Enum NUMBER_833 for value: 833
        /// </summary>
        NUMBER_833 = 833,

        /// <summary>
        /// Enum NUMBER_834 for value: 834
        /// </summary>
        NUMBER_834 = 834,

        /// <summary>
        /// Enum NUMBER_840 for value: 840
        /// </summary>
        NUMBER_840 = 840,

        /// <summary>
        /// Enum NUMBER_850 for value: 850
        /// </summary>
        NUMBER_850 = 850,

        /// <summary>
        /// Enum NUMBER_854 for value: 854
        /// </summary>
        NUMBER_854 = 854,

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
        /// Enum NUMBER_876 for value: 876
        /// </summary>
        NUMBER_876 = 876,

        /// <summary>
        /// Enum NUMBER_882 for value: 882
        /// </summary>
        NUMBER_882 = 882,

        /// <summary>
        /// Enum NUMBER_887 for value: 887
        /// </summary>
        NUMBER_887 = 887,

        /// <summary>
        /// Enum NUMBER_894 for value: 894
        /// </summary>
        NUMBER_894 = 894,

        /// <summary>
        /// Enum NUMBER_999 for value: 999
        /// </summary>
        NUMBER_999 = 999
    }

}
