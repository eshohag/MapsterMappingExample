# Mapster Mapping 

## Performance (approx benchmarks)

AutoMapper: 10–15x slower than manual mapping in benchmarks (but fine for most apps).

Mapster: ~1–2x slower than manual mapping with runtime mapping, equal speed with compile-time generation.

## ✅ Recommendation
If you’re building a new modern API and care about performance, less boilerplate, and flexibility → Mapster. <br>
If you’re maintaining a large existing enterprise app where AutoMapper is already deeply integrated → stick with AutoMapper unless performance becomes a bottleneck.

## Licensing Agreement
Mapster is free and open-source ✅ — including for commercial use.<br>
It’s licensed under the MIT License.<br>
That means you can use, modify, and distribute it in both personal and commercial projects without paying fees.<br>
No restrictions like dual-licensing or commercial-only tiers.<br>
If you use Mapster.Tool (for compile-time code generation), that’s also MIT licensed and free.<br>
So unlike some libraries that have “community vs enterprise” editions, Mapster has no paid tier — just free to use.

## ⚖️ In short:
AutoMapper → also free (MIT).<br>
Mapster → free (MIT), generally faster, more modern and microservices.
