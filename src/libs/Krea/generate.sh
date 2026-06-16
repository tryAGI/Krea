#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# Krea AI has no public OpenAPI spec as of 2026-04 — openapi.yaml is manually
# maintained from https://docs.krea.ai (and https://docs.krea.ai/llms-full.txt).
# Keep this spec in sync by diffing against the public docs when the platform
# adds/renames models.
install_autosdk_cli

rm -rf Generated

autosdk generate openapi.yaml \
  --namespace Krea \
  --clientClassName KreaClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --exclude-deprecated-operations
