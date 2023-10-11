some_func() {
  # turn any hypen-case into Capitalized.Dotted.Case 
  IFS='.' read -ra segments <<< "$1"
  local __result=""
  for __segment in "${segments[@]}"; do
      # Split the segment by hyphens
      IFS='-' read -ra hyphen_segments <<< "$__segment"
      local __formatted_segment=""

      # Process each hyphen-separated part of the segment
      for __part in "${hyphen_segments[@]}"; do
          # Capitalize each part and add it to the formatted segment
          local __formatted_part="$(tr '[:lower:]' '[:upper:]' <<<"${__part:0:1}")${__part:1}"
          __formatted_segment="${__formatted_segment}${__formatted_part}."
      done

      # Add the formatted segment to the result
      __result="${__result}${__formatted_segment}"
  done
  # remove trailing `.`
  local package_name="${__result%?}"

  echo "$package_name"
}


some_func $1
